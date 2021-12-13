using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CONCERTS
{
    public partial class Kategorii_sotrudnicov : Form
    {
        public Kategorii_sotrudnicov()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            Hide();
        }

        private void Kategorii_sotrudnicov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "concertDataSet.Kategorii_sotrudnikov". При необходимости она может быть перемещена или удалена.
            this.kategorii_sotrudnikovTableAdapter.Fill(this.concertDataSet.Kategorii_sotrudnikov);
            GetList();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-IUFK5CBJ\DIMON; Initial Catalog = Concert; User ID = sa; Password = 123");
            da = new SqlDataAdapter("Select * from Kategorii_sotrudnikov", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kategorii_sotrudnikov");
            dataGridView1.DataSource = ds.Tables["Kategorii_sotrudnikov"];
            dataGridView1.Columns[0].Visible = false;
            con.Close();
        }

        /// <summery>
        /// INSERT
        /// </summery>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = String.Format("insert into Kategorii_sotrudnikov(Naimenovanie_kategorii) values ('{0}')", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        /// <summery>
        /// UPDATE
        /// </summery>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = string.Format("update Kategorii_sotrudnikov set Naimenovanie_kategorii='{0}' where Naimenovanie_kategorii='{0}'", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summery>
        /// DELETE
        /// </summery>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = String.Format("delete from Kategorii_sotrudnikov where Naimenovanie_kategorii='{0}'", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }
    }
}
