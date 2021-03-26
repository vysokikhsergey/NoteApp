using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    /// <summary>
    /// Класс, содержащий методы для сериализации и десериализации
    /// Содержит свойство задания стандартного пути файла
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Возвращает стандартный путь файла
        /// </summary>
        public static string DefaultPath
        {
            get
            {
                var appDataFolder =
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var path = appDataFolder + @"\NoteApp\Note.json";
                return path;
            }
        }

        /// <summary>
        /// Метод сериализации
        /// </summary>
        /// <param name="project">список заметок</param>
        /// <param name="filePath">путь файла</param>
        public static void SaveToFile(Project project, string filePath)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(DefaultPath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Метод десериализации
        /// </summary>
        /// <param name="filePath">путь файла</param>
        /// <returns></returns>
        public static Project LoadFromFile(string filePath)
        {
            Project project = null;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(DefaultPath))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = serializer.Deserialize<Project>(reader);
            }
            return project;
        }
    }
}