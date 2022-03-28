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
    public partial class Добавление : Form
    {
        public Добавление()
        {
            InitializeComponent();
        }
        string img = "C:\\img\\picture.png";
        private void Добавление_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Администратор forvc = new Администратор();
            forvc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7LAIVDH;Initial Catalog=PP02;Integrated Security=True");
                con.Open();
                DataSet ds = new DataSet();
                string add = $"INSERT INTO [dbo].[Лист2$]([img],[Title],[DurationInSeconds],[Cost],[Discount])VALUES ('{img}','{textBox1.Text}',{textBox3.Text},'{textBox2.Text}','{textBox5.Text}')";
                SqlDataAdapter adp = new SqlDataAdapter(add, con);
                adp.Fill(ds);
                MessageBox.Show("Ура успешно добавлено!");

            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image;
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    img = open_dialog.FileName.ToString();
                    img = img.Replace("\\", "\\\\");
                }
                catch
                {
                    DialogResult res = MessageBox.Show("Ошибка при открытии");
                }
            }
        }
    }
}
