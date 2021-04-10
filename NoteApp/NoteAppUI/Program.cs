using System;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
            Note note = new Note("", NoteCategory.Home, "shopping list: ");
            Project project = new Project();
            project.Notes.Add(note);
            ProjectManager.SaveToFile(project, ProjectManager.DefaultPath);
            Project load = new Project();
            load = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            load.Notes[0].Name = "Buylist";
            load = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
        }
    }
}