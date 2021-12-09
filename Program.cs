using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            FileExists();
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
    }
}
