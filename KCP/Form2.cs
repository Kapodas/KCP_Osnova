using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form f;
        private void button1_Click(object sender, EventArgs e)
        {
            f = new Form3();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = new Form4();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f = new Form5();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f = new Form6();
            f.Show();
        }
    }
}
