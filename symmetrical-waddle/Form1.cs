namespace symmetrical_waddle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num += 8;
            label2.Text = $"Number: {num}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int num;
    }
}