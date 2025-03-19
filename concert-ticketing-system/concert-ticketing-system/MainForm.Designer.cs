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
            descriptionColumn = new ColumnHeader();
            durationCol = new ColumnHeader();
            startDateTimeCol = new ColumnHeader();
            performersCountCol = new ColumnHeader();
            visitorsCountCol = new ColumnHeader();
            idColumn = new ColumnHeader();
            addRecordBtn = new MaterialSkin.Controls.MaterialButton();
            nameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            startTimeTextBox = new DateTimePicker();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            durationTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            searchTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            searchButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            descriptionTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            durationFromTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            durationToTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            filterButton = new MaterialSkin.Controls.MaterialButton();
            selectedItemTextBox = new TextBox();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // concertListView
            // 
            concertListView.AutoSizeTable = false;
            concertListView.BackColor = Color.FromArgb(255, 255, 255);
            concertListView.BorderStyle = BorderStyle.None;
            concertListView.Columns.AddRange(new ColumnHeader[] { indexCol, nameCol, descriptionColumn, durationCol, startDateTimeCol, performersCountCol, visitorsCountCol, idColumn });
            concertListView.Depth = 0;
            concertListView.FullRowSelect = true;
            concertListView.Location = new Point(28, 185);
            concertListView.MinimumSize = new Size(200, 100);
            concertListView.MouseLocation = new Point(-1, -1);
            concertListView.MouseState = MaterialSkin.MouseState.OUT;
            concertListView.Name = "concertListView";
            concertListView.OwnerDraw = true;
            concertListView.Size = new Size(713, 378);
            concertListView.TabIndex = 0;
            concertListView.UseCompatibleStateImageBehavior = false;
            concertListView.View = View.Details;
            concertListView.SelectedIndexChanged += concertListView_SelectedIndexChanged;
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
            // descriptionColumn
            // 
            descriptionColumn.Text = "Description";
            descriptionColumn.Width = 200;
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
            // 
            // visitorsCountCol
            // 
            visitorsCountCol.Text = "Visitors";
            // 
            // idColumn
            // 
            idColumn.Width = 0;
            // 
            // addRecordBtn
            // 
            addRecordBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addRecordBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addRecordBtn.Depth = 0;
            addRecordBtn.HighEmphasis = true;
            addRecordBtn.Icon = null;
            addRecordBtn.Location = new Point(761, 493);
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
            nameTextBox.Location = new Point(761, 106);
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
            nameTextBox.Size = new Size(313, 48);
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
            materialLabel1.Location = new Point(761, 84);
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
            startTimeTextBox.Location = new Point(761, 450);
            startTimeTextBox.Name = "startTimeTextBox";
            startTimeTextBox.Size = new Size(313, 23);
            startTimeTextBox.TabIndex = 4;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(761, 428);
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
            durationTextBox.Location = new Point(761, 358);
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
            durationTextBox.Size = new Size(313, 48);
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
            materialLabel3.Location = new Point(761, 336);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(62, 19);
            materialLabel3.TabIndex = 7;
            materialLabel3.Text = "Duration";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(27, 96);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(130, 19);
            materialLabel4.TabIndex = 8;
            materialLabel4.Text = "Search for concert";
            // 
            // searchTextBox
            // 
            searchTextBox.AnimateReadOnly = false;
            searchTextBox.BackgroundImageLayout = ImageLayout.None;
            searchTextBox.CharacterCasing = CharacterCasing.Normal;
            searchTextBox.Depth = 0;
            searchTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchTextBox.HideSelection = true;
            searchTextBox.LeadingIcon = null;
            searchTextBox.Location = new Point(27, 118);
            searchTextBox.MaxLength = 32767;
            searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.PrefixSuffixText = null;
            searchTextBox.ReadOnly = false;
            searchTextBox.RightToLeft = RightToLeft.No;
            searchTextBox.SelectedText = "";
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionStart = 0;
            searchTextBox.ShortcutsEnabled = true;
            searchTextBox.Size = new Size(201, 48);
            searchTextBox.TabIndex = 9;
            searchTextBox.TabStop = false;
            searchTextBox.TextAlign = HorizontalAlignment.Left;
            searchTextBox.TrailingIcon = null;
            searchTextBox.UseSystemPasswordChar = false;
            // 
            // searchButton
            // 
            searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchButton.Depth = 0;
            searchButton.HighEmphasis = true;
            searchButton.Icon = Properties.Resources.icons8_search_50;
            searchButton.Location = new Point(235, 130);
            searchButton.Margin = new Padding(4, 6, 4, 6);
            searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchButton.Name = "searchButton";
            searchButton.NoAccentTextColor = Color.Empty;
            searchButton.Size = new Size(64, 36);
            searchButton.TabIndex = 10;
            searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchButton.UseAccentColor = false;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(761, 185);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(81, 19);
            materialLabel5.TabIndex = 11;
            materialLabel5.Text = "Description";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.AnimateReadOnly = false;
            descriptionTextBox.BackgroundImageLayout = ImageLayout.None;
            descriptionTextBox.CharacterCasing = CharacterCasing.Normal;
            descriptionTextBox.Depth = 0;
            descriptionTextBox.HideSelection = true;
            descriptionTextBox.Location = new Point(761, 216);
            descriptionTextBox.MaxLength = 32767;
            descriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PasswordChar = '\0';
            descriptionTextBox.ReadOnly = false;
            descriptionTextBox.ScrollBars = ScrollBars.None;
            descriptionTextBox.SelectedText = "";
            descriptionTextBox.SelectionLength = 0;
            descriptionTextBox.SelectionStart = 0;
            descriptionTextBox.ShortcutsEnabled = true;
            descriptionTextBox.Size = new Size(313, 106);
            descriptionTextBox.TabIndex = 12;
            descriptionTextBox.TabStop = false;
            descriptionTextBox.TextAlign = HorizontalAlignment.Left;
            descriptionTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(345, 64);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(62, 19);
            materialLabel6.TabIndex = 13;
            materialLabel6.Text = "Duration";
            materialLabel6.UseAccent = true;
            // 
            // durationFromTextBox
            // 
            durationFromTextBox.AnimateReadOnly = false;
            durationFromTextBox.BackgroundImageLayout = ImageLayout.None;
            durationFromTextBox.CharacterCasing = CharacterCasing.Normal;
            durationFromTextBox.Depth = 0;
            durationFromTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            durationFromTextBox.HideSelection = true;
            durationFromTextBox.LeadingIcon = null;
            durationFromTextBox.Location = new Point(345, 118);
            durationFromTextBox.MaxLength = 32767;
            durationFromTextBox.MouseState = MaterialSkin.MouseState.OUT;
            durationFromTextBox.Name = "durationFromTextBox";
            durationFromTextBox.PasswordChar = '\0';
            durationFromTextBox.PrefixSuffixText = null;
            durationFromTextBox.ReadOnly = false;
            durationFromTextBox.RightToLeft = RightToLeft.No;
            durationFromTextBox.SelectedText = "";
            durationFromTextBox.SelectionLength = 0;
            durationFromTextBox.SelectionStart = 0;
            durationFromTextBox.ShortcutsEnabled = true;
            durationFromTextBox.Size = new Size(94, 48);
            durationFromTextBox.TabIndex = 14;
            durationFromTextBox.TabStop = false;
            durationFromTextBox.TextAlign = HorizontalAlignment.Left;
            durationFromTextBox.TrailingIcon = null;
            durationFromTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(459, 130);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(5, 19);
            materialLabel7.TabIndex = 15;
            materialLabel7.Text = "-";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(345, 96);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(38, 19);
            materialLabel8.TabIndex = 16;
            materialLabel8.Text = "From";
            // 
            // durationToTextBox
            // 
            durationToTextBox.AnimateReadOnly = false;
            durationToTextBox.BackgroundImageLayout = ImageLayout.None;
            durationToTextBox.CharacterCasing = CharacterCasing.Normal;
            durationToTextBox.Depth = 0;
            durationToTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            durationToTextBox.HideSelection = true;
            durationToTextBox.LeadingIcon = null;
            durationToTextBox.Location = new Point(479, 118);
            durationToTextBox.MaxLength = 32767;
            durationToTextBox.MouseState = MaterialSkin.MouseState.OUT;
            durationToTextBox.Name = "durationToTextBox";
            durationToTextBox.PasswordChar = '\0';
            durationToTextBox.PrefixSuffixText = null;
            durationToTextBox.ReadOnly = false;
            durationToTextBox.RightToLeft = RightToLeft.No;
            durationToTextBox.SelectedText = "";
            durationToTextBox.SelectionLength = 0;
            durationToTextBox.SelectionStart = 0;
            durationToTextBox.ShortcutsEnabled = true;
            durationToTextBox.Size = new Size(94, 48);
            durationToTextBox.TabIndex = 17;
            durationToTextBox.TabStop = false;
            durationToTextBox.TextAlign = HorizontalAlignment.Left;
            durationToTextBox.TrailingIcon = null;
            durationToTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(479, 96);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(20, 19);
            materialLabel9.TabIndex = 18;
            materialLabel9.Text = "To";
            // 
            // filterButton
            // 
            filterButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            filterButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            filterButton.Depth = 0;
            filterButton.HighEmphasis = true;
            filterButton.Icon = Properties.Resources.icons8_filter_30;
            filterButton.Location = new Point(580, 130);
            filterButton.Margin = new Padding(4, 6, 4, 6);
            filterButton.MouseState = MaterialSkin.MouseState.HOVER;
            filterButton.Name = "filterButton";
            filterButton.NoAccentTextColor = Color.Empty;
            filterButton.Size = new Size(64, 36);
            filterButton.TabIndex = 19;
            filterButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            filterButton.UseAccentColor = false;
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // selectedItemTextBox
            // 
            selectedItemTextBox.BorderStyle = BorderStyle.FixedSingle;
            selectedItemTextBox.Enabled = false;
            selectedItemTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectedItemTextBox.Location = new Point(98, 569);
            selectedItemTextBox.Name = "selectedItemTextBox";
            selectedItemTextBox.Size = new Size(976, 29);
            selectedItemTextBox.TabIndex = 20;
            selectedItemTextBox.Tag = "";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(27, 575);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(65, 19);
            materialLabel10.TabIndex = 21;
            materialLabel10.Text = "Selected:";
            materialLabel10.UseAccent = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 617);
            Controls.Add(materialLabel10);
            Controls.Add(selectedItemTextBox);
            Controls.Add(filterButton);
            Controls.Add(materialLabel9);
            Controls.Add(durationToTextBox);
            Controls.Add(materialLabel8);
            Controls.Add(materialLabel7);
            Controls.Add(durationFromTextBox);
            Controls.Add(materialLabel6);
            Controls.Add(descriptionTextBox);
            Controls.Add(materialLabel5);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(materialLabel4);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 searchTextBox;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 descriptionTextBox;
        private ColumnHeader descriptionColumn;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 durationFromTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox2 durationToTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialButton filterButton;
        private TextBox selectedItemTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private ColumnHeader idColumn;
    }
}
