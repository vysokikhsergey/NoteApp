using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Note note = new Note("", NoteCategory.Home, "buy toilet paper!!1");
            Project project = new Project();
            project.List.Add(note);
            ProjectManager.SaveToFile(project, "");
            Console.WriteLine(note.Name);
            Project load = new Project();
            load = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            load.List[0].Name = "kek";
            load = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
        }
    }
}