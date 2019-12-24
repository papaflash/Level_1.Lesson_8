using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Task_4_Birthdays
{
    [Serializable]
    public class User
    {
        private string _name;
        public string Name {
            set { _name = value; }
            get { return _name; }
        }
        private DateTime _dateBirthday;
        public DateTime DateBirthday{
            set { _dateBirthday = value; }
            get { return _dateBirthday; }
        }
        public User(string name, DateTime dateTime)
        {
            Name = name;
            DateBirthday = dateTime;
        }
        public User() 
        {

        }
    }
    class Birthday
    {
        List<User> list;
        public List<User> List
        {
            get { return list; }
        }
        const string fileName = @"D:\C#\Level_1.Lesson_8\user_birthdays.xml";
        public Birthday()
        { 
            list = new List<User>();
        }
        public void Add(string name, DateTime date)
        {
            list.Add(new User(name, date));
            Save();
        }
        //public void Remove(int index)
        //{
        //    if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        //}
        // Индексатор - свойство для доступа к закрытому объекту
        public User this[int index]
        {
            get { return list[index]; }
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<User>));
            Stream fStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        //public void SaveAs()
        //{
        //    SaveFileDialog fileDialog = new SaveFileDialog();
        //    fileDialog.DefaultExt = ".xml";
        //    fileDialog.Filter = "Сохранить как xml файл (*.xml)|*.xml";
        //    if (fileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        Save(fileDialog.FileName);
        //    }
        //}
        public void Load()
        {
            try
            {
                using (Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer xmlFormat = new XmlSerializer(typeof(List<User>));
                    list = (List<User>)xmlFormat.Deserialize(fStream);
                    fStream.Close();
                }
            }catch(InvalidOperationException err)
            {
            }catch(FileNotFoundException err)
            {
                MessageBox.Show("База не найдена, будет создана по первому добавлению");
            }
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
            Application.Run(new frmBirthdays());
        }
    }
}
