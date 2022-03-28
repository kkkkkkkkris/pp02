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
    public partial class Код_подтверждения : Form
    {
        public Код_подтверждения()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Администратор forvc = new Администратор();
            forvc.Show();
            this.Hide();
        }
    }
}
