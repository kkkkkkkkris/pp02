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
    public partial class Записьнауслугу : Form
    {
        public Записьнауслугу()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 forvc = new Form1();
            forvc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7LAIVDH;Initial Catalog=PP02;Integrated Security=True");
                con.Open();
                DataSet ds = new DataSet();
                string add = $"INSERT INTO [dbo].[Клиентсервис]([Услуга],[Клиент],[Начало оказания услуги])VALUES ('{textBox1.Text}','{textBox3.Text}','{textBox2.Text}')";
                SqlDataAdapter adp = new SqlDataAdapter(add, con);
                adp.Fill(ds);
                MessageBox.Show("Ура вы записались!");

            }
            catch
            {
                MessageBox.Show("Что-то пошло не так");
            }

            //string str = @"Data Source=DESKTOP-7LAIVDH;Initial Catalog=PP02;Integrated Security=True";
            //SqlConnection myConnection = new SqlConnection(str);
            //myConnection.Open();
            //string zapros;//переменные для запросов
            //SqlCommand com;

            //if (textBox1.Text != "" && textBox3.Text != "" && textBox2.Text != "")//если не введены данные в поля
            //{
            //    zapros = $"INSERT INTO [dbo].[Клиентсервис]([Услуга],[Клиент],[Начало оказания услуги])VALUES((select max (Услуга) from Клиентсервис)+1, N'{textBox1.Text}', N'{textBox3.Text}', N'{textBox2.Text}')";//запросы
            //    com = new SqlCommand(zapros, myConnection);
            //    com.ExecuteNonQuery();
            //    MessageBox.Show("Успешно добавлено!");
            //}
            //else
            //{
            //    MessageBox.Show("Заполните все поля!");
            //}
            //myConnection.Close();
        }
    }
}
