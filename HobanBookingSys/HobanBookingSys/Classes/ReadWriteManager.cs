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

        // Paths should be @"..\..\DBfiles\*file*.txt"
        //eg. @"..\..\DBfiles\AccountDataFile.txt"
        protected static string[] ReadFromFile(string path)
        {
            // the iusing means it is disposed of at the end of the using
            using (StreamReader sr = File.OpenText(path))
            {
                // wrap it in a try for error handling
                try
                {
                    // read the whole file
                    string TmpString = sr.ReadToEnd();
                    // close the stream reader 
                    sr.Close();
                    // split the string based off newline, creating a string[] that is returned
                    return TmpString.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                }
                //incase of errors write the message to the console
                catch (IOException ioex)
                {
                    Console.WriteLine(ioex.Message);
                    return new string[1];
                }
            }
        }

        protected void WriteToFile(string path, string[] Content)
        {
            //tmp .txt file @"..\..\DBfiles\*file*.txt"
            string TmpPath = $@"..\..\DBfiles\{Path.GetFileNameWithoutExtension(path)}01.txt";

            using (var sw = new StreamWriter(TmpPath))
            {

                foreach (string line in Content)
                {
                    try
                    {
                        sw.Write($"{line}{Environment.NewLine}");
                    }
                    catch (IOException ioex)
                    {
                        Console.WriteLine(line);
                        Console.WriteLine(ioex.Message);
                    }
                }

                sw.Close();
            }

            using (FileStream SourceS = File.Open(TmpPath, FileMode.Open))
            {
                using (FileStream DestS = File.Create(path))
                {
                    try
                    {
                        SourceS.CopyTo(DestS);
                    }
                    catch (IOException ioex)
                    {
                        Console.WriteLine(ioex);
                    }
                }
            }

            File.Delete(TmpPath);

        }



        // this was for the async code, although im not sure how to make it work as it just freezes program



        //public static async Task<string[]> ReadFromFile(string path)
        //{

        //    using (StreamReader sd = File.OpenText(path))
        //    {
        //        try
        //        {
        //            string TmpString = await sd.ReadToEndAsync();
        //            sd.Close();
        //            return TmpString.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        //        }
        //        catch (ArgumentException e)
        //        {
        //            Console.WriteLine(e.Message);
        //            return new string[1];
        //        }
        //    }
        //}

        //public static async Task WriteToFile(string path, string[] Content)
        //{
        //    //tmp .txt file @"..\..\DBfiles\*file*.txt"
        //    string TmpPath = $@"..\..\DBfiles\{Path.GetFileNameWithoutExtension(path)}01.txt";

        //    using (var sw = new StreamWriter(TmpPath))
        //    {
        //        var TaskList = new List<Task>();

        //        foreach (string line in Content)
        //        {
        //            try
        //            {
        //                TaskList.Add(sw.WriteAsync(line));
        //            }
        //            catch (IOException ioex)
        //            {
        //                Console.WriteLine(line);
        //                Console.WriteLine(ioex.Message);
        //            }
        //        }

        //        await Task.WhenAll(TaskList);
        //        sw.WriteLine("");
        //        sw.Close();
        //    }

        //    using (FileStream SourceS = File.Open(TmpPath, FileMode.Open))
        //    {
        //        using (FileStream DestS = File.Create(path))
        //        {
        //            try
        //            {
        //                await SourceS.CopyToAsync(DestS);
        //            }
        //            catch (IOException ioex)
        //            {
        //                Console.WriteLine(ioex);
        //            }
        //        }
        //    }

        //    File.Delete(TmpPath);
        //}
    }
}
