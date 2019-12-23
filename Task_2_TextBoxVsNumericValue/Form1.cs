using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_TextBoxVsNumericValue
{
    public partial class Task2Frm : Form
    {
        public Task2Frm()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ErrorLbl.Text = "";
                numericUpDown1.Value = Convert.ToInt32(textBox1.Text);
            }catch(FormatException err)
            {
                ErrorLbl.Text = err.Message;
            }
        }
    }
}
