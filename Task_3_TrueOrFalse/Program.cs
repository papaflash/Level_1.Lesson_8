using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Task_3_TrueOrFalse
{
    [Serializable]
    public class Question
    {
        private string _text;
        public string Text { // Текст вопроса
            get { return _text; }
            set { _text = value; } 
        }  
        
        private bool _trueFalse;
        public bool TrueFalse
        {
            get { return _trueFalse; }
            set { _trueFalse = value; } // Правда или нет
        }

        public Question()       // Для сериализации должен быть пустой конструктор.
        {
        }
        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }
    }
    // Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML
    class TrueFalse
    {
        List<Question> list;
        private string _fileName;
        public string FileName
        {
            set { _fileName = value; }

        }
        public TrueFalse(string fileName)
        {
            FileName = fileName;
            list = new List<Question>();
        }
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        // Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get { return list[index]; }
        }
        public void Save(String fileName = "")
        {
            if (String.IsNullOrEmpty(fileName))
                fileName = _fileName;

            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void SaveAs()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.DefaultExt = ".xml";
            fileDialog.Filter = "Сохранить как xml файл (*.xml)|*.xml";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Save(fileDialog.FileName);
            }
        }
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public int Count
        {
            get { return list.Count; }
        }
    }

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
            Application.Run(new Form1());
        }
    }
}
