using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json;


namespace day15
{
    class FileIO
    {

        public static List<Car> ReadfromFile(String filename)
        {
            try
            {
                StreamReader reader = new StreamReader(filename);
                String line = reader.ReadLine();
                String json = "";

                while (line != null)
                {
                    json += line;
                    line = reader.ReadLine();
                }
                reader.Close();

                return JsonConvert.DeserializeObject<List<Car>>(json);
            }
            catch
            {
                return null;
            }
        }


        //

        public static void WriteToFile(String cars, String filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename, true);
                    sw.WriteLine(cars);
                sw.Close();
}
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }


    }
}
