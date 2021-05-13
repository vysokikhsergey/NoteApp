using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {
        private Note _note = new Note();

        public NoteForm()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(NoteCategory)))
            {
                NoteCategoryComboBox.Items.Add(item);
            }
        }

        public Note Note
        {
            get 
            {
                return _note;
            }
            set 
            {
                _note = (Note)value.Clone();
                if (_note != null)
                {
                    TitleTextBox.Text = _note.Name;
                    NoteCategoryComboBox.SelectedItem = _note.Category;
                    CreatedTimePicker.Value = _note.TimeCreated;
                    ModifiedTimePicker.Value = _note.TimeModified;
                    TextBox.Text = _note.Text;
                }
                else 
                {
                    TitleTextBox.Text = "Untitled";
                    _note.Name = TitleTextBox.Text;
                    CreatedTimePicker.Value = DateTime.Now;
                    ModifiedTimePicker.Value = DateTime.Now;
                }
            }
        }

        private void NoteCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _note.Category = (NoteCategory)NoteCategoryComboBox.SelectedItem;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                _note.Name = TitleTextBox.Text;
                _note.Category = (NoteCategory)NoteCategoryComboBox.SelectedItem;
                _note.TimeCreated = CreatedTimePicker.Value;
                _note.TimeModified = ModifiedTimePicker.Value;
                _note.Text = TextBox.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException exception)
            {
                DialogResult result = MessageBox.Show
                (
                "Note name is too large: more than 50 characters",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}