using System;
using System.Text;
using Newtonsoft.Json;
using System.IO;


namespace NoteApp
{
    /// <summary>
    /// Класс, содержащий методы для сериализации и десериализации.
    /// Содержит свойство задания стандартного пути файла.
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Возвращает стандартный путь файла.
        /// </summary>
        public static string DefaultPath
        {
            get
            {
                var appDataFolder =
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var path = appDataFolder + @"\Vysokikh\NoteApp\Note.json";
                return path;
            }
        }

        /// <summary>
        /// Метод сериализации.
        /// </summary>
        /// <param name="project">Список заметок.</param>
        /// <param name="filePath">Путь файла.</param>
        public static void SaveToFile(Project project, string filePath)
        {
            var directoryFile = Path.GetDirectoryName(filePath);
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryFile);
            if (!Directory.Exists(directoryFile))
            {
                directoryInfo.Create();
            }

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, project);
                }
            }
        }
        /// <summary>
        /// Метод десериализации.
        /// </summary>
        /// <param name="filename">Имя файла.</param>
        /// <returns></returns>
        public static Project LoadFromFile(string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    Project emptyProject = new Project();
                    return emptyProject;
                }
                var project = new Project();
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(filename))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = serializer.Deserialize<Project>(reader);
                }
                return project;
            }
            catch(Exception exception)
            {
                return new Project();
            }
        }
    }
}