namespace Final643450086_6_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            sweet sweet = new sweet();
            sweet.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            drink drink = new drink();
            drink.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ขอบคุณครับ");
            Close();
        }
    }
}