using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONCERTS
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "12345")
                {
                    Welcome wl = new Welcome();
                    wl.Show();
                    Hide();
                }
            }
            else
                MessageBox.Show("Пароль не верный");
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
