namespace KomisSamochodowy
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.typeLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.addEntry = new System.Windows.Forms.Button();
            this.additionalLabel = new System.Windows.Forms.Label();
            this.additionalBox = new System.Windows.Forms.TextBox();
            this.additionalCheckbox = new System.Windows.Forms.CheckBox();
            this.entryView = new System.Windows.Forms.DataGridView();
            this.seachLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.sportsCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.entryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(895, 25);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(37, 13);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type :";
            // 
            // brandLabel
            // 
            this.brandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(895, 55);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(41, 13);
            this.brandLabel.TabIndex = 2;
            this.brandLabel.Text = "Brand :";
            // 
            // modelLabel
            // 
            this.modelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(895, 82);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(42, 13);
            this.modelLabel.TabIndex = 3;
            this.modelLabel.Text = "Model :";
            // 
            // yearLabel
            // 
            this.yearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(895, 111);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(100, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year of production :";
            // 
            // typeBox
            // 
            this.typeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Family",
            "Offroad"});
            this.typeBox.Location = new System.Drawing.Point(938, 22);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(151, 21);
            this.typeBox.TabIndex = 6;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // brandBox
            // 
            this.brandBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brandBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.brandBox.Location = new System.Drawing.Point(942, 52);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(147, 20);
            this.brandBox.TabIndex = 7;
            this.brandBox.WordWrap = false;
            // 
            // modelBox
            // 
            this.modelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modelBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.modelBox.Location = new System.Drawing.Point(938, 79);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(151, 20);
            this.modelBox.TabIndex = 8;
            this.modelBox.WordWrap = false;
            // 
            // yearBox
            // 
            this.yearBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearBox.Location = new System.Drawing.Point(1001, 108);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(88, 20);
            this.yearBox.TabIndex = 9;
            this.yearBox.WordWrap = false;
            this.yearBox.TextChanged += new System.EventHandler(this.yearBox_TextChanged);
            // 
            // addEntry
            // 
            this.addEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addEntry.Location = new System.Drawing.Point(1097, 20);
            this.addEntry.Name = "addEntry";
            this.addEntry.Size = new System.Drawing.Size(75, 23);
            this.addEntry.TabIndex = 10;
            this.addEntry.Text = "Add Entry";
            this.addEntry.UseVisualStyleBackColor = true;
            this.addEntry.Click += new System.EventHandler(this.addEntry_Click);
            // 
            // additionalLabel
            // 
            this.additionalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalLabel.AutoSize = true;
            this.additionalLabel.Location = new System.Drawing.Point(895, 137);
            this.additionalLabel.Name = "additionalLabel";
            this.additionalLabel.Size = new System.Drawing.Size(59, 13);
            this.additionalLabel.TabIndex = 13;
            this.additionalLabel.Text = "Additional :";
            // 
            // additionalBox
            // 
            this.additionalBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.additionalBox.Enabled = false;
            this.additionalBox.Location = new System.Drawing.Point(1054, 134);
            this.additionalBox.Name = "additionalBox";
            this.additionalBox.Size = new System.Drawing.Size(118, 20);
            this.additionalBox.TabIndex = 14;
            // 
            // additionalCheckbox
            // 
            this.additionalCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalCheckbox.AutoSize = true;
            this.additionalCheckbox.Enabled = false;
            this.additionalCheckbox.Location = new System.Drawing.Point(1001, 136);
            this.additionalCheckbox.Name = "additionalCheckbox";
            this.additionalCheckbox.Size = new System.Drawing.Size(48, 17);
            this.additionalCheckbox.TabIndex = 15;
            this.additionalCheckbox.Text = "[y/n]";
            this.additionalCheckbox.UseVisualStyleBackColor = true;
            // 
            // entryView
            // 
            this.entryView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entryView.Location = new System.Drawing.Point(12, 12);
            this.entryView.Name = "entryView";
            this.entryView.Size = new System.Drawing.Size(877, 637);
            this.entryView.TabIndex = 16;
            this.entryView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.entryView_CellContentClick);
            // 
            // seachLabel
            // 
            this.seachLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.seachLabel.AutoSize = true;
            this.seachLabel.Location = new System.Drawing.Point(895, 226);
            this.seachLabel.Name = "seachLabel";
            this.seachLabel.Size = new System.Drawing.Size(47, 13);
            this.seachLabel.TabIndex = 17;
            this.seachLabel.Text = "Search :";
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(948, 223);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(119, 20);
            this.searchBox.TabIndex = 18;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(1073, 221);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(52, 23);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(KomisSamochodowy.Car);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(1097, 50);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(1131, 221);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(52, 23);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.seachLabel);
            this.Controls.Add(this.entryView);
            this.Controls.Add(this.additionalCheckbox);
            this.Controls.Add(this.additionalBox);
            this.Controls.Add(this.additionalLabel);
            this.Controls.Add(this.addEntry);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.typeLabel);
            this.MaximumSize = new System.Drawing.Size(1280, 1080);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form";
            this.Text = "Komis Samochodowy";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Button addEntry;
        private System.Windows.Forms.Label additionalLabel;
        private System.Windows.Forms.TextBox additionalBox;
        private System.Windows.Forms.CheckBox additionalCheckbox;
        private System.Windows.Forms.DataGridView entryView;
        private System.Windows.Forms.Label seachLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.BindingSource sportsCarBindingSource;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
    }
}

