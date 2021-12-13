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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Authorization Au = new Authorization();
            Au.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategorii_sotrudnicov Ks = new Kategorii_sotrudnicov();
            Ks.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Concert Cn = new Concert();
            Cn.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Zritel Zr = new Zritel();
            Zr.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Concert_zal Cz = new Concert_zal();
            Cz.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sotrudnic_concerta Sc = new Sotrudnic_concerta();
            Sc.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bilet Bl = new Bilet();
            Bl.Show();
            Hide();
        }
    }
}
