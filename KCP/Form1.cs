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
                MessageBox.Show("Нельзя выбрать день который уже прошел!!");
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
            
            MessageBox.Show("Что делает это приложение? \n" +
                "Это приложение рассчитывает кратчайший и выгодный путь для пассажира, который учитывает:\n" +
                "1. Дистанцию\n" +
                "2. Трафик в определенное время\n" +
                "3. Цену\n");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            f = new Form2();
            f.Show();
        }
    }
}