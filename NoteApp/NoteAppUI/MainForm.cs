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
        private Project _notes = new Project();
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _notes = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            FillNoteListBox();
        }

       
    }
}
