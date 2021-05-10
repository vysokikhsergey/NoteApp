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
            Application.Run(new MainForm());
            Note note = new Note("", NoteCategory.Home, "shopping list: ");
            Note note1 = new Note("Почему важно коммитить", NoteCategory.HealthAndSport, "Чтобы не потерять файлы блин нахрен");
            Project project = new Project();
            project.Notes.Add(note);
            project.Notes.Add(note1);
            ProjectManager.SaveToFile(project, ProjectManager.DefaultPath);
            Project load = new Project();
            load = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            load.Notes[0].Name = "Buylist";
            load = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
        }
    }
}