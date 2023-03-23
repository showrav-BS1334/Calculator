namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int ans = 0;
        char sign;
        int a, b;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text = "";
            a = 0;
            b = 0;
            ans = 0;
        }
        private void b0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b0.Text;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b1.Text;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b2.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b3.Text;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b4.Text;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b5.Text;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b6.Text;
        }
        private void b7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b7.Text;
        }
        private void b8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b0.Text;
        }
        private void b9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b0.Text;
        }
        private void bClear_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b0.Text;
        }
        private void bEqual_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + b0.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            display.Text += b0.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sign = '^';
            a = Convert.ToInt32(display.Text);
            display.Clear();
            //display.Text.Clone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text += b1.Text;
        }

        private void b2_Click_1(object sender, EventArgs e)
        {
            display.Text += b2.Text;
        }

        private void b3_Click_1(object sender, EventArgs e)
        {
            display.Text += b3.Text;
        }

        private void b4_Click_1(object sender, EventArgs e)
        {
            display.Text += b4.Text;
        }

        private void b5_Click_1(object sender, EventArgs e)
        {
            display.Text += b5.Text;
        }

        private void b6_Click_1(object sender, EventArgs e)
        {
            display.Text += b6.Text;
        }

        private void b7_Click_1(object sender, EventArgs e)
        {
            display.Text += b7.Text;
        }

        private void b8_Click_1(object sender, EventArgs e)
        {
            display.Text += b8.Text;
        }

        private void b9_Click_1(object sender, EventArgs e)
        {
            display.Text += b9.Text;
        }

        private void bEqual_Click_1(object sender, EventArgs e)
        {
            b = Convert.ToInt32(display.Text);
            if (sign == '+') ans = a + b;
            else if (sign == '-') ans = a - b;
            else if (sign == '/') ans = a / b;
            else if (sign == '*') ans = a * b;
            else if (sign == '%') ans = a % b;
            else if (sign == '^') ans = a ^ b;

            display.Text = ans.ToString();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            sign = '+';
            a = Convert.ToInt32(display.Text);
            display.Clear();
        }

        private void bSubtract_Click(object sender, EventArgs e)
        {
            sign = '-';
            a = Convert.ToInt32(display.Text);
            display.Clear();
        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            sign = '*';
            a = Convert.ToInt32(display.Text);
            display.Clear();
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            sign = '/';
            a = Convert.ToInt32(display.Text);
            display.Clear();
        }

        private void bMod_Click(object sender, EventArgs e)
        {
            sign = '%';
            a = Convert.ToInt32(display.Text);
            display.Clear();
            //display.Text.Clone();
        }
    }
}