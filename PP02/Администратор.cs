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
    public partial class Администратор : Form
    {
        public Администратор()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Добавление form3 = new Добавление();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Редактирование f = new Редактирование();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Записиклиентов hhhr = new Записиклиентов();
            hhhr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Записиклиентов hhhr = new Записиклиентов();
            hhhr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 forvc = new Form1();
            forvc.Show();
            this.Hide();
        }
    }
}
