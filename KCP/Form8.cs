using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace KCP
{
    public partial class Form8 : Form
    {
        Form1 MF1 = new Form1();
        public Form8(DateTimePicker Val, int i)
        {
            InitializeComponent();
            Val = MF1.dateTimePicker1;
            label2.Text = Raschet.FirstIterat(Val, i);
            
            label3.Text = Calculation.FirstIterat(Val, i);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
