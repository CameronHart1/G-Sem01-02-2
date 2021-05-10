using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobanBookingSys
{
    public class StringListConverter
    {
        // combines all the array elements, with | as the divisor
        public string ConvertToString(List<string> inArray)
        {
            string tempString = "";
            foreach (string entry in inArray)
            {
                tempString += $"{entry}|";
            }
            if (tempString.Length > 0)
            {
                return tempString.Remove(tempString.Length - 1);
            }
            return "";
        }

        // splits the string using | as the splitter
        public List<string> ListFromString(string inString)
        {
            return inString.Split('|').ToList<string>();
        }
    }
}
