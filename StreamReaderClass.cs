using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class StreamReaderClass
    {
        public static void writePath()
        {
            string path = @"D:\Brize\github\FileIO\file.txt";
            StreamWriter sr = File.AppendText(path);
            {
                sr.WriteLine("Hello World - .net is awsome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
        public static void readPath()
        {
            string path = @"D:\Brize\github\FileIO\file.txt";
            StreamReader sr = File.OpenText(path);
            string s = "";
            while((s=sr.ReadLine())!=null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
