using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HobanBookingSys
{
    class ReadWriteManager
    {
        protected async Task<string[]> ReadFromFile(string Path)
        {

            //using (StreamWriter file = new StreamWriter("logins.txt", true));
            //await file.WriteLineAsync("insert line");

            // just an empty return for debug purposes
            return new string[5];
        }

        protected async Task WriteToFile(string Path)
        {

            //using (StreamWriter file = new StreamWriter("logins.txt", true));
            //await file.WriteLineAsync("insert line");

            // might consider writing to a new file (eg. $"{Path}New") then when thats complete
            // copy contents of PathNew to Path and delete PathNew
            //File.Copy($"{Path}New", Path,true);
            //File.delete($"{Path}New")
        }
    }
}
