using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    ///Класс, содержащий список всех заметок
    /// </summary>
    public class Project
    {
       /// <summary>
       /// Поле, хранящее список заметок
       /// </summary>
        public List<Note> List { get; set; } = new List<Note>();
    }
}