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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void СоздатьЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void ВашаОрганизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void ОписаниеВашегоОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void СвязатьсяСНамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }

        private void ИнформацияОРаботеСПриложениемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }
    }
}
