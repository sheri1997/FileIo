using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //FleExists();
            //readLines();
            //readText();
            //StreamReaderClass.writePath();
            //StreamReaderClass.readPath();
            BinarySerizable.serialiZed();
            BinarySerizable.deSeializabe();
        }
        public static void FileExists()
        {
            string path = @"D:\Brize\github\FileIO\file.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File is Present");
            }
            else
            {
                Console.WriteLine("No File is Present");
            }
        }
        public static void readLines()
        {
            string path = @"D:\Brize\github\FileIO\file.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
        }
        public static void readText()
        {
            string path = @"D:\Brize\github\FileIO\file.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
    }
}
