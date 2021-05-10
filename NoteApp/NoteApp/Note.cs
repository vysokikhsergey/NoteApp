using System;


namespace NoteApp
{
    /// <summary>
    /// Класс заметки, хранящий информацию об имени, категории,
    /// тексте, времени создания и времени последнего изменения заметки.
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Имя заметки.
        /// </summary>
        private string _name;
        
        /// <summary>
        /// Категория заметки.
        /// </summary>
        private NoteCategory _category;

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Время создания заметки.
        /// </summary>
        private DateTime _timeCreated;

        /// <summary>
        /// Время последнего изменения заметки.
        /// </summary>
        private DateTime _timeModified;


        /// <summary>
        /// Задает и возвращает имя заметки, выполняет проверку на количество символов. 
        /// Если поле ввода пустое, задает имя Untitled.
        /// При изменении имени меняет время последнего изменения заметки.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    _name = "Untitled";
                    return;
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Note title exceeds 50 characters");
                }
                _name = value;
                TimeModified = DateTime.Now;
            }
        }
        
        /// <summary>
        /// Задает и возвращает категорию заметки.
        /// При смене категории меняет время последнего изменения заметки.
        /// </summary>
        public NoteCategory Category 
        { 
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                TimeModified = DateTime.Now;
            }
        }

        /// <summary>
        /// Задает и возвращает текст заметки.
        /// При изменении текста меняет время последнего изменения заметки.
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                TimeModified = DateTime.Now;
            }
        }

        /// <summary>
        /// Задает и возвращает время создания заметки.
        /// </summary>
        public DateTime TimeCreated
        {
            get
            {
                return _timeCreated;
            }
            set 
            {
                _timeCreated = DateTime.Now;
            }
        }

        /// <summary>
        /// Задает и возвращает время последнего изменения заметки.
        /// </summary>
        public DateTime TimeModified
        {
            get
            {
                return _timeModified;
            }
            set
            {
                _timeModified = DateTime.Now;
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя заметки.</param>
        /// <param name="category">Категория заметки.</param>
        /// <param name="text">Текст заметки.</param>
        public Note(string name, NoteCategory category, string text)
        {
            Name = name;
            Category = category;
            Text = text;
        }
        
        /// <summary>
        /// Приватный конструктор класса, задающий время
        /// </summary>
        /// <param name="name">Имя заметкию</param>
        /// <param name="category">Категория заметки.</param>
        /// <param name="text">Текст заметки.</param>
        /// <param name="timeCreated">Время создания заметки.</param>
        /// <param name="timeModified">Время изменения заметки</param>
        private Note(string name, NoteCategory category, string text, DateTime timeCreated, DateTime timeModified)
        {
            Name = name;
            Category = category;
            Text = text;
            TimeCreated = timeCreated;
            TimeModified = timeModified;
        }
        
        /// <summary>
        /// Реализация интерфейса ICloneable
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Note(Name, Category, Text, TimeCreated, TimeModified)
            {
                Name = this.Name,
                Category = this.Category,
                Text = this.Text,
                TimeCreated = this.TimeCreated,
                TimeModified = this.TimeModified
            };
        }
    }
}