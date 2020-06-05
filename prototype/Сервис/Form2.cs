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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ПерейтиНаГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void ВашаОрганиацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void ВашеОборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void СвязьСНамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }

        private void ИнформацииОЗаполненииЗапросаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }
    }
}
