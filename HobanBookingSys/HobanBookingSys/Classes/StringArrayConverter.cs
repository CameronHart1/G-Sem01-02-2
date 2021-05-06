using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobanBookingSys
{
    class StringArrayConverter
    {
        public string ConvertToString(string[] inArray)
        {
            string tempString = "";
            foreach (string entry in inArray)
            {
                tempString += $"{entry}|";
            }

            return tempString.Remove(tempString.Length - 1);
        }
    }
}
