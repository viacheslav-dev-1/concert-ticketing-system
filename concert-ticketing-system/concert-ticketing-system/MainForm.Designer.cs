namespace concert_ticketing_system
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            concertListView = new MaterialSkin.Controls.MaterialListView();
            indexCol = new ColumnHeader();
            nameCol = new ColumnHeader();
            durationCol = new ColumnHeader();
            startDateTimeCol = new ColumnHeader();
            performersCountCol = new ColumnHeader();
            visitorsCountCol = new ColumnHeader();
            addRecordBtn = new MaterialSkin.Controls.MaterialButton();
            nameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            startTimeTextBox = new DateTimePicker();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            durationTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // concertListView
            // 
            concertListView.AutoSizeTable = false;
            concertListView.BackColor = Color.FromArgb(255, 255, 255);
            concertListView.BorderStyle = BorderStyle.None;
            concertListView.Columns.AddRange(new ColumnHeader[] { indexCol, nameCol, durationCol, startDateTimeCol, performersCountCol, visitorsCountCol });
            concertListView.Depth = 0;
            concertListView.FullRowSelect = true;
            concertListView.Location = new Point(23, 90);
            concertListView.MinimumSize = new Size(200, 100);
            concertListView.MouseLocation = new Point(-1, -1);
            concertListView.MouseState = MaterialSkin.MouseState.OUT;
            concertListView.Name = "concertListView";
            concertListView.OwnerDraw = true;
            concertListView.Size = new Size(576, 336);
            concertListView.TabIndex = 0;
            concertListView.UseCompatibleStateImageBehavior = false;
            concertListView.View = View.Details;
            // 
            // indexCol
            // 
            indexCol.Text = "#";
            // 
            // nameCol
            // 
            nameCol.Text = "Name";
            nameCol.Width = 100;
            // 
            // durationCol
            // 
            durationCol.Text = "Duration";
            durationCol.Width = 100;
            // 
            // startDateTimeCol
            // 
            startDateTimeCol.Text = "Start Time";
            startDateTimeCol.Width = 100;
            // 
            // performersCountCol
            // 
            performersCountCol.Text = "Performers";
            performersCountCol.Width = 120;
            // 
            // visitorsCountCol
            // 
            visitorsCountCol.Text = "Visitors";
            visitorsCountCol.Width = 120;
            // 
            // addRecordBtn
            // 
            addRecordBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addRecordBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addRecordBtn.Depth = 0;
            addRecordBtn.HighEmphasis = true;
            addRecordBtn.Icon = null;
            addRecordBtn.Location = new Point(716, 373);
            addRecordBtn.Margin = new Padding(4, 6, 4, 6);
            addRecordBtn.MouseState = MaterialSkin.MouseState.HOVER;
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.NoAccentTextColor = Color.Empty;
            addRecordBtn.Size = new Size(64, 36);
            addRecordBtn.TabIndex = 1;
            addRecordBtn.Text = "ADD";
            addRecordBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addRecordBtn.UseAccentColor = false;
            addRecordBtn.UseVisualStyleBackColor = true;
            addRecordBtn.Click += addRecordBtn_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.AnimateReadOnly = false;
            nameTextBox.BackgroundImageLayout = ImageLayout.None;
            nameTextBox.CharacterCasing = CharacterCasing.Normal;
            nameTextBox.Depth = 0;
            nameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameTextBox.HideSelection = true;
            nameTextBox.LeadingIcon = null;
            nameTextBox.Location = new Point(632, 124);
            nameTextBox.MaxLength = 32767;
            nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PasswordChar = '\0';
            nameTextBox.PrefixSuffixText = null;
            nameTextBox.ReadOnly = false;
            nameTextBox.RightToLeft = RightToLeft.No;
            nameTextBox.SelectedText = "";
            nameTextBox.SelectionLength = 0;
            nameTextBox.SelectionStart = 0;
            nameTextBox.ShortcutsEnabled = true;
            nameTextBox.Size = new Size(234, 48);
            nameTextBox.TabIndex = 2;
            nameTextBox.TabStop = false;
            nameTextBox.TextAlign = HorizontalAlignment.Left;
            nameTextBox.TrailingIcon = null;
            nameTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(632, 102);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(43, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Name";
            // 
            // startTimeTextBox
            // 
            startTimeTextBox.CustomFormat = "dd/MM/yyyy hh:mm tt";
            startTimeTextBox.Format = DateTimePickerFormat.Custom;
            startTimeTextBox.Location = new Point(632, 320);
            startTimeTextBox.Name = "startTimeTextBox";
            startTimeTextBox.Size = new Size(234, 23);
            startTimeTextBox.TabIndex = 4;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(632, 298);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(75, 19);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Start Time";
            // 
            // durationTextBox
            // 
            durationTextBox.AnimateReadOnly = false;
            durationTextBox.BackgroundImageLayout = ImageLayout.None;
            durationTextBox.CharacterCasing = CharacterCasing.Normal;
            durationTextBox.Depth = 0;
            durationTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            durationTextBox.HideSelection = true;
            durationTextBox.LeadingIcon = null;
            durationTextBox.Location = new Point(632, 228);
            durationTextBox.MaxLength = 32767;
            durationTextBox.MouseState = MaterialSkin.MouseState.OUT;
            durationTextBox.Name = "durationTextBox";
            durationTextBox.PasswordChar = '\0';
            durationTextBox.PrefixSuffixText = null;
            durationTextBox.ReadOnly = false;
            durationTextBox.RightToLeft = RightToLeft.No;
            durationTextBox.SelectedText = "";
            durationTextBox.SelectionLength = 0;
            durationTextBox.SelectionStart = 0;
            durationTextBox.ShortcutsEnabled = true;
            durationTextBox.Size = new Size(234, 48);
            durationTextBox.TabIndex = 6;
            durationTextBox.TabStop = false;
            durationTextBox.TextAlign = HorizontalAlignment.Left;
            durationTextBox.TrailingIcon = null;
            durationTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(632, 206);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(62, 19);
            materialLabel3.TabIndex = 7;
            materialLabel3.Text = "Duration";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(materialLabel3);
            Controls.Add(durationTextBox);
            Controls.Add(materialLabel2);
            Controls.Add(startTimeTextBox);
            Controls.Add(materialLabel1);
            Controls.Add(nameTextBox);
            Controls.Add(addRecordBtn);
            Controls.Add(concertListView);
            Name = "MainForm";
            Text = "Concert Schedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView concertListView;
        private MaterialSkin.Controls.MaterialButton addRecordBtn;
        private ColumnHeader indexCol;
        private ColumnHeader nameCol;
        private ColumnHeader durationCol;
        private ColumnHeader startDateTimeCol;
        private ColumnHeader performersCountCol;
        private ColumnHeader visitorsCountCol;
        private MaterialSkin.Controls.MaterialTextBox2 nameTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DateTimePicker startTimeTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 durationTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}
