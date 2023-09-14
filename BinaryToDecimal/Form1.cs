namespace BinaryToDecimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void ConfBtn_Click(object sender, EventArgs e)
        {
            DecTxt.Clear();
            if (CheckBinary.CheckBinaryNumb(BinTxt.Text))
            {
                BinTxt.Clear();
            }
            int Result = 0;
            BinToDecCal(BinTxt.Text);

            DecTxt.Text = Convert.ToString(BinToDecCal(BinTxt.Text));


        }
        public static int BinToDecCal(string a)
        {
            int Result = 0;
            int x = a.Length - 1;
            foreach (char b in a)
            {
                if (b == '1')
                {
                    Result += (int)Math.Pow(2, x);
                    x--;
                }
                else
                {
                    x--;
                }

            }
            return Result;
        }
    }
}