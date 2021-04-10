using System.Collections.Generic;


namespace NoteApp
{
    /// <summary>
    ///Класс, содержащий список всех заметок.
    /// </summary>
    public class Project
    {
       /// <summary>
       /// Поле, хранящее список заметок.
       /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}