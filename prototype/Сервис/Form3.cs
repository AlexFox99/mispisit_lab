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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "песситDataSet.Б_Е". При необходимости она может быть перемещена или удалена.
            this.б_ЕTableAdapter.Fill(this.песситDataSet.Б_Е);

        }

        private void ГлавнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void ИнформацияОРаботеСоСправочникомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }

        private void СвяьСНамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }
    }
}
