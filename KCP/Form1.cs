namespace KCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form f;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("������ ������� ���� ������� ��� ������!!");
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = new Form7();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("��� ������ ��� ����������? \n" +
                "��� ���������� ������������ ���������� � �������� ���� ��� ���������, ������� ���������:\n" +
                "1. ���������\n" +
                "2. ������ � ������������ �����\n" +
                "3. ����\n");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            f = new Form2();
            f.Show();
        }
    }
}