using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Note:ICloneable
    {
        /// <summary>
        /// Имя заметки
        /// </summary>
        private string _name;
        
        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _category;

        /// <summary>
        /// Текст заметки
        /// </summary>
        private string _text;

        /// <summary>
        /// Время создания заметки
        /// </summary>
        private DateTime _timeCreation;

        /// <summary>
        /// Время последнего изменения заметки
        /// </summary>
        private DateTime _timeLastChange;


        /// <summary>
        /// Задает и возвращает имя заметки, выполняет проверку на количество символов. 
        /// Если поле ввода пустое, задает имя Untitled
        /// При изменении имени меняет время последнего изменения заметки
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
                TimeLastChange = DateTime.Now;
            }
        }
        
        /// <summary>
        /// Задает и возвращает категорию заметки.
        /// При смене категории меняет время последнего изменения заметки
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
                TimeLastChange = DateTime.Now;
            }
        }

        /// <summary>
        /// Задает и возвращает текст заметки.
        /// При изменении текста меняет время последнего изменения заметки
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
                TimeLastChange = DateTime.Now;
            }
        }

        /// <summary>
        /// Задает и возвращает время создания заметки
        /// </summary>
        public DateTime TimeCreation
        {
            get
            {
                return _timeCreation;
            }
            private set 
            {
                _timeCreation = DateTime.Now;
            }
        }

        /// <summary>
        /// Задает и возвращает время последнего изменения заметки
        /// </summary>
        public DateTime TimeLastChange
        {
            get
            {
                return _timeLastChange;
            }
            set
            {
                _timeLastChange = DateTime.Now;
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">имя заметки</param>
        /// <param name="category">категория заметки</param>
        /// <param name="text">текст заметки</param>
        public Note(string name, NoteCategory category, string text)
        {
            Name = name;
            Category = category;
            Text = text;
            TimeCreation = DateTime.Now;
            TimeLastChange = DateTime.Now;
        }

        /// <summary>
        /// Реализация интерфейска ICloneable
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Note(Name, Category, Text);
        }
    }
}