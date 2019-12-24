using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_TrueOrFalse
{
    
    public partial class Form1 : Form
    {
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
            catch (NullReferenceException err)
            {
                MessageBox.Show($"{err.Message}\nНе загружен файл, не чего прокручивать!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }

        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            try
            {
                database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
            }catch(NullReferenceException err)
            {
                MessageBox.Show($"{err.Message}\nНе выбран файл для сохранения, не чего сохранять!");
            }
        }

        private void authorMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор из методички Geek Brains");
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            if (database != null) database.SaveAs();
            else MessageBox.Show("База данных не создана");
        }
    }
}
