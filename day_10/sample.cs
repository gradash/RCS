using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace day_10
{
    class sample
    {
        public static string filename;

        public static void Write(List<string> userInput)
        {
            
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\grada\\Desktop\\"+filename, false);

                for (int i = 0; i < userInput.Count; i++)
                {
                    sw.WriteLine(userInput[i]);
                }

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }


        public static List<string> Read()
        {
            String line;
            List<string> b = new List<string>();
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\grada\\Desktop\\"+filename);
                
                line = sr.ReadLine();
                while (line != null)
                {
                    b.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                
            }
            
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
            }
            return b;
        }




    }
}
