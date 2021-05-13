namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifiedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.CategorySelectedLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NoteCategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.NoteListBox);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CategorySelectedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NoteNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NoteTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(862, 450);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 0;
            // 
            // NoteCategoryComboBox
            // 
            this.NoteCategoryComboBox.FormattingEnabled = true;
            this.NoteCategoryComboBox.Location = new System.Drawing.Point(112, 31);
            this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
            this.NoteCategoryComboBox.Size = new System.Drawing.Size(171, 24);
            this.NoteCategoryComboBox.TabIndex = 5;
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveNoteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveNoteButton.FlatAppearance.BorderSize = 0;
            this.RemoveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveNoteButton.Image")));
            this.RemoveNoteButton.Location = new System.Drawing.Point(63, 423);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(24, 24);
            this.RemoveNoteButton.TabIndex = 4;
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.FlatAppearance.BorderSize = 0;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.Image")));
            this.EditNoteButton.Location = new System.Drawing.Point(33, 423);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(24, 24);
            this.EditNoteButton.TabIndex = 3;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddNoteButton.FlatAppearance.BorderSize = 0;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.Image")));
            this.AddNoteButton.Location = new System.Drawing.Point(3, 423);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(24, 24);
            this.AddNoteButton.TabIndex = 2;
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(3, 34);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(103, 17);
            this.ShowCategoryLabel.TabIndex = 1;
            this.ShowCategoryLabel.Text = "ShowCategory:";
            // 
            // NoteListBox
            // 
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.ItemHeight = 16;
            this.NoteListBox.Location = new System.Drawing.Point(3, 59);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(280, 356);
            this.NoteListBox.TabIndex = 0;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitAltF4ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitAltF4ToolStripMenuItem
            // 
            this.exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            this.exitAltF4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitAltF4ToolStripMenuItem.Text = "Exit (Alt + F4)";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.addToolStripMenuItem.Text = "Add Note";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.editToolStripMenuItem1.Text = "Edit Note";
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutF1ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutF1ToolStripMenuItem
            // 
            this.aboutF1ToolStripMenuItem.Name = "aboutF1ToolStripMenuItem";
            this.aboutF1ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.aboutF1ToolStripMenuItem.Text = "About (F1)";
            // 
            // ModifiedTimePicker
            // 
            this.ModifiedTimePicker.Enabled = false;
            this.ModifiedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifiedTimePicker.Location = new System.Drawing.Point(267, 97);
            this.ModifiedTimePicker.Name = "ModifiedTimePicker";
            this.ModifiedTimePicker.Size = new System.Drawing.Size(108, 22);
            this.ModifiedTimePicker.TabIndex = 7;
            // 
            // CreatedTimePicker
            // 
            this.CreatedTimePicker.Enabled = false;
            this.CreatedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedTimePicker.Location = new System.Drawing.Point(73, 97);
            this.CreatedTimePicker.Name = "CreatedTimePicker";
            this.CreatedTimePicker.Size = new System.Drawing.Size(107, 22);
            this.CreatedTimePicker.TabIndex = 6;
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Location = new System.Drawing.Point(196, 102);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(65, 17);
            this.ModifiedLabel.TabIndex = 5;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(5, 102);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(62, 17);
            this.CreatedLabel.TabIndex = 4;
            this.CreatedLabel.Text = "Created:";
            // 
            // CategorySelectedLabel
            // 
            this.CategorySelectedLabel.AutoSize = true;
            this.CategorySelectedLabel.Location = new System.Drawing.Point(70, 73);
            this.CategorySelectedLabel.Name = "CategorySelectedLabel";
            this.CategorySelectedLabel.Size = new System.Drawing.Size(155, 17);
            this.CategorySelectedLabel.TabIndex = 3;
            this.CategorySelectedLabel.Text = "CategorySelectedLabel";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(5, 73);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category:";
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteNameLabel.Location = new System.Drawing.Point(3, 34);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(209, 29);
            this.NoteNameLabel.TabIndex = 1;
            this.NoteNameLabel.Text = "NoteNameLabel";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(8, 125);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ReadOnly = true;
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(552, 313);
            this.NoteTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.ComboBox NoteCategoryComboBox;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker ModifiedTimePicker;
        private System.Windows.Forms.DateTimePicker CreatedTimePicker;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label CategorySelectedLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label NoteNameLabel;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutF1ToolStripMenuItem;
    }
}

