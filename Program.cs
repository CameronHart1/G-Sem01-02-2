using System;
using System.IO;
using System.Threading.Tasks;

namespace Login_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static async Task Example()
        {
            using StreamWriter file = new StreamWriter("logins.txt", true);
            await file.WriteLineAsync("insert line");
        }


    }
}
