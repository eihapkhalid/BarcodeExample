using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeExample.Classes
{
    internal class Item
    {
        #region Variables
        public int CategoryNumber { get; set; }
        public decimal ItemPrice { get; set; }
        public int ItemNumber { get; set; }
        public string? ItemName { get; set; }
        #endregion

        #region Methodes
        public string GetFormatedCategoryNumber(int number)
        {
            String NewNumber = Convert.ToString(number);
            string returnedNumber = string.Empty;
            for (int i = 0; i < 3 - NewNumber.Length; i++)
            {
                returnedNumber += "0";
            }
            return returnedNumber + NewNumber;
        }

        public string GetFormatedPriceNumber(decimal number)
        {
            String NewNumber = Convert.ToString(number);
            string returnedNumber = string.Empty;
            for (int i = 0; i < 5 - NewNumber.Length; i++)
            {
                returnedNumber += "0";
            }
            return returnedNumber + NewNumber;
        }


        public string GetFormatedItemNumber(int number)
        {
            String NewNumber = Convert.ToString(number);
            string returnedNumber = string.Empty;
            for (int i = 0; i < 5 - NewNumber.Length; i++)
            {
                returnedNumber += "0";
            }
            return returnedNumber + NewNumber;
        }

        #endregion
    }
}
