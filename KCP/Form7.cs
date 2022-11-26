using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace KCP
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Form1 f = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimePicker Val;
            Val = f.dateTimePicker1;
            Form l = new Form8(Val, 0);
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTimePicker Val;
            Val = f.dateTimePicker1;
            Form l = new Form8(Val, 1);
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DateTimePicker Val;
            Val = f.dateTimePicker1;
            Form l = new Form8(Val, 2);
            l.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            DateTimePicker Val;
            Val = f.dateTimePicker1;
            Form l = new Form8(Val, 3);
            l.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            DateTimePicker Val;
            Val = f.dateTimePicker1;
            Form l = new Form8(Val, 4);
            l.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            DateTimePicker Val;
            Val = f.dateTimePicker1;
            Form l = new Form8(Val, 5);
            l.Show();
        }
    }
}
