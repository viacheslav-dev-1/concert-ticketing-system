using MaterialSkin;
using MaterialSkin.Controls;
using System.Globalization;

namespace concert_ticketing_system
{
    public partial class MainForm : MaterialForm
    {
        private readonly DataManager dataManager;

        public MainForm()
        {
            InitializeComponent();

            dataManager = new DataManager();

            // Create a material theme manager and apply it to the form
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Define the color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue700,
                Primary.Blue100, Accent.LightBlue200,
                TextShade.WHITE);
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

                var startDateTime = DateTime.Now;
                if (DateTime.TryParseExact(startTimeTextBox.Text, "dd/MM/yyyy hh:mm tt",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var dateResult))
                {
                    startDateTime = dateResult;
                };

                var id = Guid.NewGuid();
                var concert = new Concert(id, name, descriptionTextBox.Text, duration, startDateTime, new List<Performer>(), new List<Visitor>());

                // Write to file using FileManager's WriteToFile method
                //FileManager.WriteToFile(concert);

                // Add to collection for future data manipulation using DataManager's Add method
                dataManager.Add(concert);

                var item = new ListViewItem(concertListView.Items.Count + 1 + "");
                item.SubItems.Add(name);
                item.SubItems.Add(descriptionTextBox.Text);
                item.SubItems.Add(durationTextBox.Text);
                item.SubItems.Add(startDateTime.ToString("dd/MM/yyyy hh:mm tt"));
                item.SubItems.Add("0");
                item.SubItems.Add("0");
                item.SubItems.Add(id.ToString());

                concertListView.Items.Add(item);
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // if there are no entites, we don't perform search and exit this method
                if (!dataManager.Entities.Any())
                {
                    return;
                }

                // Remove all items from the list to fill the list view only with found items
                concertListView.Items.Clear();


                IEnumerable<IEntity> foundEntities = new List<IEntity>();
                if (string.IsNullOrEmpty(searchTextBox.Text))
                {
                    // If user left searchTextBox empty, load all concerts
                    foundEntities = dataManager.Entities;
                }
                else
                {
                    // Otherwise, perform search on Concert list
                    // DataManager searches items in DataManager.Entitites list.
                    // In this list we added items in addRecordBtn_Click handler
                    foundEntities = dataManager.Search(searchTextBox.Text);
                }

                foreach (IEntity entity in foundEntities)
                {
                    // We cast our IEntity entity to Concert type to obtain all required data
                    // Before casting, IEntity had only Id property, but we need all Concert-related (Name, ...)
                    // We can cast IEntity type to Concert type because Concert implements IEntity interface
                    var concertEntity = entity as Concert;

                    // If casting is successful, fill our listView with found concert items
                    if (concertEntity != null)
                    {
                        var item = new ListViewItem(concertListView.Items.Count + 1 + "");
                        item.SubItems.Add(concertEntity.Name);
                        item.SubItems.Add(concertEntity.Description);
                        item.SubItems.Add(concertEntity.Duration.ToString());
                        item.SubItems.Add(concertEntity.StartDateTime != null
                            ? concertEntity.StartDateTime.Value.ToString("dd/MM/yyyy hh:mm tt")
                            : string.Empty
                            );
                        item.SubItems.Add("0");
                        item.SubItems.Add("0");
                        item.SubItems.Add(entity.Id.ToString());

                        concertListView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            try
            {
                // if there are no entites, we don't perform search and exit this method
                if (!dataManager.Entities.Any())
                {
                    return;
                }

                // Remove all items from the list to fill the list view only with filtered items
                concertListView.Items.Clear();

                IEnumerable<IEntity> filteredEntities = new List<IEntity>();
                if (string.IsNullOrEmpty(durationFromTextBox.Text) || string.IsNullOrEmpty(durationToTextBox.Text))
                {
                    // If user left searchTextBox empty, load all concerts
                    filteredEntities = dataManager.Entities;
                }
                else
                {
                    // Otherwise, perform filter on Concert list
                    // DataManager filters items over DataManager.Entitites list.
                    // DataManager.Filter accepts a delegate as parametr so we can pass a lambda expression
                    filteredEntities = dataManager.Filter(entity =>
                    {
                        TimeSpan? durationFrom = null;
                        if (TimeSpan.TryParse(durationFromTextBox.Text, out var durationFromResult))
                            durationFrom = durationFromResult;

                        TimeSpan? durationTo = null;
                        if (TimeSpan.TryParse(durationToTextBox.Text, out var durationToResult))
                            durationTo = durationToResult;

                        if (entity is Concert concert && concert.Duration != null && durationFrom != null && durationTo != null)
                            return concert.Duration >= durationFrom && concert.Duration <= durationTo;
                        else
                            return false;
                    });

                    foreach (IEntity entity in filteredEntities)
                    {
                        // We can simplify casting like this
                        // We check if entity is Concert type and cast it to Concert type at the same time
                        if (entity is Concert concertEntity)
                        {
                            var item = new ListViewItem(concertListView.Items.Count + 1 + "");
                            item.SubItems.Add(concertEntity.Name);
                            item.SubItems.Add(concertEntity.Description);
                            item.SubItems.Add(concertEntity.Duration.ToString());
                            item.SubItems.Add(concertEntity.StartDateTime != null
                                ? concertEntity.StartDateTime.Value.ToString("dd/MM/yyyy hh:mm tt")
                                : string.Empty
                                );
                            item.SubItems.Add("0");
                            item.SubItems.Add("0");
                            item.SubItems.Add(entity.Id.ToString());

                            concertListView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void concertListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure an item is selected
            if (concertListView.SelectedItems.Count > 0) 
            {
                // Get the selected index
                int selectedIndex = concertListView.SelectedIndices[0];

                // Get the selected item's text
                string selectedItemText = concertListView.SelectedItems[0].SubItems[7].Text;

                // Convert to the Guid
                var id = Guid.Parse(selectedItemText);

                // Get Entity using indexer
                IEntity? entity = dataManager[id];
                if (entity != null)
                {
                    // Cast our entity to Concert type
                    if (entity is Concert concert)
                    {
                        var formattedText = concert.Format();
                        selectedItemTextBox.Text = formattedText;
                    }
                }
            }
        }
    }
}
