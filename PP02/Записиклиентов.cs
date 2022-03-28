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

namespace PP02
{
    public partial class Записиклиентов : Form
    {
        public Записиклиентов()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = @"Data Source=DESKTOP-7LAIVDH;Initial Catalog=PP02;Integrated Security=True";
            string n = textBox1.Text;
            string zapros = $"select [Услуга], [Начало оказания услуги], [Клиент] from [Клиентсервис] where [Услуга] like '%{n}%'";
            using (SqlConnection connection = new SqlConnection(a))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(zapros, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Администратор form3 = new Администратор();
            form3.Show();
            this.Hide();
        }
    }
}
