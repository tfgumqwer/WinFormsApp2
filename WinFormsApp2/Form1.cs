namespace WinFormsApp2
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int box1 = int.Parse(textBox1.Text);
            int box2 = int.Parse(textBox2.Text);

            int asd = box1 + box2;
            textBox3.Text = asd.ToString();      

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int box1 = int.Parse(textBox1.Text);
            int box2 = int.Parse(textBox2.Text);

            int asd = box1 - box2;
            if (asd => 0)
            {
               
            }
            textBox3.Text = asd.ToString();
        }
    }
}