namespace _a_b_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            
            


                double sum = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
                textBox3.Text = sum.ToString();
            
            

            


        }
    }
}