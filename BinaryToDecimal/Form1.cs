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
            BinToDecCal(BinTxt.Text,ref Result);

            DecTxt.Text = Convert.ToString(Result);


        }
        public static void BinToDecCal(string a,ref int Result)
        {
            int x = a.Length -1 ;
            foreach (char b in a)
            { 
                if (b == '1')
                {
                    int y = 1;
                    y = (int)Math.Pow(2,x) * y;
                    x--;
                    Result += y;
                }
                else
                {
                    x--;
                }
            }
          }
    }
}