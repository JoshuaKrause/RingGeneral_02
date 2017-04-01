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
        const string loadPath = @"C:\Users\VFX_07_2\Documents\Visual Studio 2015\Projects\RingGeneral_02\ringGeneralData.txt";
        const string savePath = @"C:\Users\VFX_07_2\Documents\Visual Studio 2015\Projects\RingGeneral_02\ringGeneralData2.txt";

        public static Dictionary<string, Character> characters;
        public static Dictionary<string, Tag> tags;

        static List<dynamic> dataList = new List<dynamic>();

        // Loads data into a series of Dictionaries.
        public static void LoadData(string path = null)
        {
            // If no path is supplied, use the default.
            if (path == null)
                path = loadPath;

            // Initialize our data string and the file stream.
            string data;
            FileStream fileStream = null;

            // Import all data.
            try
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                using (TextReader textReader = new StreamReader(fileStream))
                {
                    fileStream = null;
                    data = textReader.ReadToEnd();
                }
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Dispose();
            }

            // Deserialize the data.
            Deserializer.Deserialize(data, out characters, out tags);

            // Add the new dictionaries to the data list.
            dataList.Add(characters);
            dataList.Add(tags);
        }

        public static void SaveData(string path = null)
        {
            // If no path is supplied, use the default.
            if (path == null)
                path = savePath;

            string data = Serializer.Serialize(dataList);

            // Write all data.
            try
            {
                using (TextWriter textWriter = new StreamWriter(path))
                {
                    textWriter.Write(data);
                    textWriter.Flush();
                    textWriter.Close();
                }                  
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
