namespace BinaryToDecimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txbDecimal.Clear();

            if (CheckBinary.CheckBinaryNumber(txbBinary.Text))
            {
                txbBinary.Clear();
            }

            txbDecimal.Text = BinToDecCal(txbBinary.Text).ToString();
        }

        private double BinToDecCal(string value)
        {
            double result = 0;
            int x = value.Length - 1;

            foreach (char b in value)
            {
                if (b == '1')
                {
                    result += Math.Pow(2, x);
                }
                x--;
            }

            return result;
        }
    }
}