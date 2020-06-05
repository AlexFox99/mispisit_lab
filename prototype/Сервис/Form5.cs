using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сервис
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void ГлавнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
