using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    public class CheckBinary
    {
        public static bool CheckBinaryNumb(string a)
        {
            Regex regex = new Regex("^[01]*$");
            if (a == null)
            {
                MessageBox.Show("Please Enter a Valid Decimal Number(only consist of 1 and 0)","Null Warning");
            }
            else if (!regex.IsMatch(a))
            {
                MessageBox.Show("Please Enter a Valid Decimal Number(only consist of 1 and 0)","Warning");
                return true;
            }
            return false;
        }
    }
}
