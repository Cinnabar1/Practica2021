using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            //this.Enabled = false;
        }

        private void ButtonDownErrors_Click(object sender, EventArgs e)
        {
            if (dtpBegin.Value > dtpEnd.Value) {
                MessageBox.Show("Ошибка","Начальное значение превосходит финальное");

            }
        }
    }
}
