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
    public partial class frmBirthdayList : Form
    {
        public frmBirthdayList()
        {
            InitializeComponent();
            Show();
        }
        public void LoadList(List<User> list)
        { 
            foreach (var user in list)
            {
                listBox1.Items.Add($"{user.Name}, {user.DateBirthday:dd MMMM}");
            }
        }

    }
}
