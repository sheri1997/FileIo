using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO
{
    class BinarySerizable
    {
        public static void serialiZed()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"D:\Brize\github\FileIO\Example.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
        }
        public static void deSeializabe()
        {
            FileStream fileStream = new FileStream(@"D:\Brize\github\FileIO\Example.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo desiriali = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"Aplication Name{desiriali.ApplicationName} --Application Id{desiriali.ApplicationId}");
        }
    }
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "BinarySerizable";
        public int ApplicationId { get; set; } = 1001;
    }
}

            