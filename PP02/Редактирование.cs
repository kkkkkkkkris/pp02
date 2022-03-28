using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP02
{
    public partial class Редактирование : Form
    {
        public Редактирование()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Администратор forvc = new Администратор();
            forvc.Show();
            this.Hide();
        }
    }
}
