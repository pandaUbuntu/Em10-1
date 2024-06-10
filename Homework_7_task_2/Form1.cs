namespace Homework_7_task_2
{
    public partial class Form1 : Form
    {
        double dividend;
        double divisor;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            divisor = Convert.ToDouble(textBox2.Text);
            dividend = Convert.ToDouble(textBox1.Text);

            if (divisor == 0)
                MessageBox.Show("На 0 ділити не можна!");
            else
                result = dividend / divisor;
            label1.Text = Convert.ToString(result);

        }



        private void label1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(Convert.ToString(result));

        }
    }
}