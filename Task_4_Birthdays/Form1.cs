using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4_Birthdays
{
    public partial class frmBirthdays : Form
    {
        Birthday birthday;
        bool dateChange;
        public frmBirthdays()
        {
            InitializeComponent();
            birthday = new Birthday();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tBoxUsers.Text != "" && dateChange == true)
            {
                    birthday.Add(tBoxUsers.Text, dtPickerBirthday.Value);
                    dateChange = false;
            }
        }

        private void dtPickerBirthday_ValueChanged(object sender, EventArgs e)
        {
            dateChange = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            new frmBirthdayList().LoadList(birthday.List);
        }

        private void frmBirthdays_Load(object sender, EventArgs e)
        { 
            birthday.Load();         
        }
    }
}
