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
    public partial class Sotrudnic_concerta : Form
    {
        public Sotrudnic_concerta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            Hide();
        }

        private void Sotrudnic_concerta_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "concertDataSet.Sotrudnic_concerta". При необходимости она может быть перемещена или удалена.
            this.sotrudnic_concertaTableAdapter.Fill(this.concertDataSet.Sotrudnic_concerta);
            GetList();

        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-IUFK5CBJ\DIMON; Initial Catalog = Concert; User ID = sa; Password = 123");
            da = new SqlDataAdapter("Select * from Sotrudnic_concerta", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Sotrudnic_concerta");
            dataGridView1.DataSource = ds.Tables["Sotrudnic_concerta"];
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
            cmd.CommandText = String.Format("insert into Sotrudnic_concerta(Familia, Imay, Otchestvo, Data_rogdenia, Nomer_telefona, Seria_i_nomer_paspirta, Zarplara, Kategorii_sotrudnikov_id) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, comboBox1.Text);
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
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox1.Text == "")
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
                    cmd.CommandText = string.Format("update Sotrudnic_concerta set Familia='{0}', Imay='{1}', Otchestvo='{2}', Data_rogdenia='{3}', Nomer_telefona='{4}', Seria_i_nomer_paspirta='{5}', Zarplara='{6}', Kategorii_sotrudnikov_id='{7}' where Imay='{1}'", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, comboBox1.Text);
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
            cmd.CommandText = String.Format("delete from Sotrudnic_concerta where Familia='{0}'", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }
    }
}
