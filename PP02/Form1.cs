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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string adm;
        static string pro;
        public int i;
        string filtr = "", search = "", sort = "";
        int id;
        public static string connectionString = @"Data Source=DESKTOP-7LAIVDH;Initial Catalog=PP02;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Код_подтверждения form3 = new Код_подтверждения();
            form3.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                sort = "";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                sort = " order by Лист2$.Cost ASC";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                sort = " order by Лист2$.Cost DESC";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Все")
            {
                filtr = "";
            }
            else if (comboBox1.Text == "От 0 до 5%")
            {
                filtr = $" AND Discount >=0 and Discount <=5";
            }
            else if (comboBox1.Text == "От 5% до 15%")
            {
                filtr = $" AND Discount >=5 and Discount <=15";
            }
            else if (comboBox1.Text == "От 15% до 30%")
            {
                filtr = $" AND Discount >=15 and Discount <=30";
            }
            else if (comboBox1.Text == "От 30% до 70%")
            {
                filtr = $" AND Discount >=30 and Discount <=70";
            }
            else if (comboBox1.Text == "От 70% до 100%")
            {
                filtr = $" AND Discount >=70 and Discount <=100";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Записьнауслугу form3 = new Записьнауслугу();
            form3.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = @"Data Source=DESKTOP-7LAIVDH;Initial Catalog=PP02;Integrated Security=True";
            string n = textBox1.Text;
            string zapros = $"select * from Лист2$ where Title like '%{n}%'";
            using (SqlConnection connection = new SqlConnection(a))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(zapros, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
