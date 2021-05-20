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
    public partial class MainForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Список всех заметок
        /// </summary>
        private Project _notes = new Project();
        
        /// <summary>
        /// Метод заполнения NoteListBox
        /// </summary>
        private void FillNoteListBox()
        {
            NoteListBox.Items.Clear();
            for (int i = 0; i < _notes.Notes.Count; i++)
            {
                NoteListBox.Items.Add(_notes.Notes[i].Name);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            _notes = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            foreach (var item in Enum.GetValues(typeof(NoteCategory)))
            {
                NoteCategoryComboBox.Items.Add(item);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NoteNameLabel.Text = "";
            CategorySelectedLabel.Text = "";
            _notes = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            FillNoteListBox();
        }

        /// <summary>
        /// Метод очищения полей с данными заметки
        /// </summary>
        private void ClearMainFormData()
        {
            NoteNameLabel.Text = "";
            CategorySelectedLabel.Text = "";
            NoteTextBox.Clear();
        }
        
        /// <summary>
        /// Метод добавления заметки
        /// </summary>
        private void AddNote()
        {
            var addNote = new NoteForm();
            addNote.ShowDialog();
            if (addNote.DialogResult == DialogResult.OK)
            {
                var newNote = addNote.Note;
                _notes.Notes.Add(newNote);
                NoteListBox.Items.Add(newNote.Name);
                ProjectManager.SaveToFile(_notes, ProjectManager.DefaultPath);
                NoteListBox.SelectedIndex = NoteListBox.Items.Count - 1;
            }
        }

        /// <summary>
        /// Метод редактирования заметки
        /// </summary>
        private void EditNote()
        {
            if (NoteListBox.SelectedIndex == -1)
            {
                return;
            }
            var indexNote = NoteListBox.SelectedIndex;
            var selectedData = _notes.Notes[indexNote];
            var editNote = new NoteForm();
            editNote.Note = selectedData;
            editNote.ShowDialog();
            if (editNote.DialogResult == DialogResult.OK)
            {
                var updatedNote = editNote.Note;
                _notes.Notes.RemoveAt(indexNote);
                _notes.Notes.Add(updatedNote);
                NoteListBox.Items.RemoveAt(indexNote);
                NoteListBox.Items.Add(updatedNote.Name);
                ProjectManager.SaveToFile(_notes, ProjectManager.DefaultPath);
                NoteListBox.SelectedIndex = NoteListBox.Items.Count - 1;
            }
        }
       
        /// <summary>
        /// Метод удаления заметки
        /// </summary>
        private void RemoveNote()
        {
            if (NoteListBox.SelectedIndex == -1)
            {
                return;
            }
            var indexNote = NoteListBox.SelectedIndex;
            var selectedData = _notes.Notes[indexNote];
            var dialogResult = MessageBox.Show
                (
                "Do you really want to remove this note: " + selectedData.Name,
                "Remove Note",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }
            _notes.Notes.RemoveAt(indexNote);
            NoteListBox.Items.RemoveAt(indexNote);
            ProjectManager.SaveToFile(_notes, ProjectManager.DefaultPath);
            ClearMainFormData();
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteListBox.SelectedIndex == -1)
            {
                NoteNameLabel.Text = "";
                CategorySelectedLabel.Text = "";
                return;
            }
            int index = NoteListBox.SelectedIndex;
            var note = _notes.Notes[index];
            NoteNameLabel.Text = note.Name;
            CategorySelectedLabel.Text = note.Category.ToString();
            CreatedTimePicker.Value = note.TimeCreated;
            ModifiedTimePicker.Value = note.TimeModified;
            NoteTextBox.Text = note.Text;
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectManager.SaveToFile(_notes, ProjectManager.DefaultPath);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //не работает((
            if (e.KeyCode == Keys.F1)
            {
                var aboutForm = new AboutForm();
                aboutForm.Show();
            }
        }

        private void NoteListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveNote();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}