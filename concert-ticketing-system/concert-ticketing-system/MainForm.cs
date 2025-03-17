using MaterialSkin;
using MaterialSkin.Controls;

namespace concert_ticketing_system
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            // Create a material theme manager and apply it to the form
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Define the color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue700,
                Primary.Blue100, Accent.LightBlue200,
                TextShade.WHITE);

            var entitites = FileManager.Read<Concert>("Concert.txt");

            var s = 1;
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var name = nameTextBox.Text;
                TimeSpan? duration = null;
                if (TimeSpan.TryParse(durationTextBox.Text, out var durationResult))
                {
                    duration = durationResult;
                };

                DateTime? startDateTime = DateTime.Now;
                if (DateTime.TryParse(startTimeTextBox.Text, out var dateResult))
                {
                    startDateTime = dateResult;
                };

                var id = Guid.NewGuid();
                var concert = new Concert(id, name, duration, startDateTime, new List<Performer>(), new List<Visitor>());

                FileManager.Add(concert);

                var item = new ListViewItem(concertListView.Items.Count + 1 + "");
                item.SubItems.Add(name);
                item.SubItems.Add(durationTextBox.Text);
                item.SubItems.Add(startTimeTextBox.Text);
                item.SubItems.Add("0");
                item.SubItems.Add("0");

                concertListView.Items.Add(item);
            } 
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }        
        }
    }
}
