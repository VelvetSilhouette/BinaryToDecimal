using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    public static class CheckBinary
    {
        public static bool CheckBinaryNumber(string value)
        {
            Regex regex = new Regex("^[01]*$");

            if (value == "" || !regex.IsMatch(value))
            {
                MessageBox.Show("Please enter a valid Decimal Number(only consist of 1 and 0).", (value == "") ? "Null Warning" : "Warning");
                return true;
            }

            return false;
        }
    }
}
