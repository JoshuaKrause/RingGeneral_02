using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RingGeneral
{
    static class DataControl
    {
        const string dataPath = @"C:\Users\jkrau\Desktop\ringGeneralData.txt";

        public static Dictionary<string, Character> characters = new Dictionary<string, Character>();
        public static Dictionary<string, Tag> tags = new Dictionary<string, Tag>();

        static public void DataReader(string path = null)
        {
            if (string.IsNullOrEmpty(path))
                path = dataPath;

            FileStream fileStream = File.OpenRead(path);
            StreamReader reader = new StreamReader(fileStream);

            string rawData = reader.ReadToEnd();
            reader.Close();

            Console.WriteLine(rawData);
        }
    }
}
