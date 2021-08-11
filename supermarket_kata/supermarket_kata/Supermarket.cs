using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket_kata
{
    public class Supermarket
    {

        public bool CheckIfUnitPriceIsNumeric<T>(T price)
        {
            double x;
            return Double.TryParse(price.ToString(), out x);
        }

        public bool CheckIfUnitPriceIsNumeric(string price)
        {

            string number = price.ToString();
            number = number[number.Length - 1] == 'f' ? number.Substring(0, number.Length - 1) : number;

            double x;
            return Double.TryParse(number, out x);

        }


        public bool CheckIfUnitPricesIsNumeric<T>(List<T> prices)
        {

            try
            {
                foreach (var price in prices)
                {
                    string number = price.ToString();
                    number = number[number.Length - 1] == 'f' ? number.Substring(0, number.Length - 1) : number;
                    double x = Convert.ToDouble(number);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }


        public bool CheckIfValueIsNull<T>(List<T> prices)
        {

            foreach (var price in prices)
            {
                if (price == null)
                    return true;
            }

            return false;

        }


        public bool CheckIfItemIsFree(List<double> prices)
        {
            foreach (var price in prices)
            {
                if (price <= 0)
                    return true;
            }

            return false;

        }

        public bool CheckTwoOccurences(IDictionary<string, int> occurences)
        {
            foreach (var price in occurences)
            {
                if (price.Value == 2)
                    return true;
            }

            return false;

        }

        public bool CheckOneOccurence(IDictionary<string, int> occurences)
        {
            foreach (var price in occurences)
            {
                if (price.Value == 1)
                    return true;
            }

            return false;

        }

        public bool CheckThreeOccurences(IDictionary<string, int> occurences)
        {
            foreach (var price in occurences)
            {
                if (price.Value == 3)
                    return true;
            }

            return false;

        }

    }
}
