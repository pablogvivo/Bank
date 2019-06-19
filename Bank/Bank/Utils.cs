using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Bank
{
    class Utils
    {
        /// <summary>
        /// Parese an string to a float number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static float fNumber(String input) {
            try
            {

                float temp=0;
                float.TryParse(input.Replace(".",","), out temp); //Format the  
                return temp;
            }
            catch (Exception ex) {
               
                return 0;
            }
        }

        public static bool IBANCheck(String input) {
            try
            {
                if (string.IsNullOrEmpty(input))
                    return false;

                var asciiShift = 55;
                input = input.ToUpper();

                if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[A-Z0-9]"))
                    return false;

                //Delete any whitespace
                input = input.Replace(" ", string.Empty);
                var rearrangedIban = input.Substring(4, input.Length - 4) + input.Substring(0, 4);

                //Convert to integer checksum
                var stringBuilder = new StringBuilder();
                foreach (var ibanChar in rearrangedIban)
                {
                    int convertedValue;
                    if (char.IsLetter(ibanChar))
                        convertedValue = ibanChar - asciiShift;
                    else
                        convertedValue = int.Parse(ibanChar.ToString());
                    stringBuilder.Append(convertedValue);
                }

                //Modulo operation on IBAN checksum
                var checkSumString = stringBuilder.ToString();
                var checksum = int.Parse(checkSumString.Substring(0, 1));
                for (var i = 1; i < checkSumString.Length; i++)
                {
                    checksum *= 10;
                    checksum += int.Parse(checkSumString.Substring(i, 1));
                    checksum %= 97;
                }
                return checksum == 1;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool justLetter(String input) {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^[a-zA-Z]+$"))
                    return false;
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public static bool emailCheck(String input)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(input);
                return addr.Address == input;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// Check that all the TextBox in the Control are not Empty
        /// </summary>
        /// <param name="Father"></param>
        /// <returns></returns>
        public static bool notEmptyTextBox(Control.ControlCollection Father) {
            try {
                if (Father.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                    return false; 
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public static void resetTextbox(Control.ControlCollection Father) {
            try
            {
                Father.OfType<TextBox>().ToList().ForEach(t => t.Clear());
            }
            catch (Exception ex)
            {
            }
        }
    }
}
