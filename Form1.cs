namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Calculator calc;

        public Form1()
        {
            InitializeComponent();
            calc = new Calculator(); // instantiate the logic
        }
        private void add_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(num1.Text);
            double n2 = double.Parse(num2.Text);
            double res = calc.Add(n1, n2);
            result.Text = res.ToString();
        }



        // Multiply button


        // Divide button
       

        private void sub_Click_1(object sender, EventArgs e)
        {
            double n1 = double.Parse(num1.Text);
            double n2 = double.Parse(num2.Text);
            double res = calc.Subtract(n1, n2);
            result.Text = res.ToString();
        }



        private void multiply_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(num1.Text);
            double n2 = double.Parse(num2.Text);
            double res = calc.Multiply(n1, n2);
            result.Text = res.ToString();
        }

        private void devide_Click_1(object sender, EventArgs e)
        {
            double n1 = double.Parse(num1.Text);
            double n2 = double.Parse(num2.Text);

            try
            {
                double res = calc.Divide(n1, n2);
                result.Text = res.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
