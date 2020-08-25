using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace day_10
{
    class menuengine
    {




        public static void MenuEngine() {

            while (true)
            {
            Console.WriteLine("1 Atvert failu");
            Console.WriteLine("2 Izvadīt faila saturu");
            Console.WriteLine("3 Pievienot tekstu");
            Console.WriteLine("4 Saglabat failu ar citu vardu? y/n");
            Console.WriteLine("5 Dzēst tekstu");
            
                int caseSwitch = Convert.ToInt32(Console.ReadLine());

           
                switch (caseSwitch)
                {



                    case 1:
                        
                        string[] files = Directory.GetFiles("C:\\Users\\grada\\Desktop\\", "*.txt");
                        foreach (string file in files)
                        Console.WriteLine(Path.GetFileName(file));
                        Console.WriteLine("Kadu failu atvert?:");
                        string filename = Console.ReadLine();
                        sample.filename = filename;

                        break;

                    case 2:
                        Console.WriteLine("Saraksts faila " + sample.filename);
                        foreach (string line in sample.Read())
                        {
                            Console.WriteLine(line);
                            
                        }
                        Console.WriteLine();
                        break;


                    case 3:
                        string yesno;
                        do
                        {
                            Console.WriteLine("Pievienot elementu");
                            List<string> userInput = new List<string>();  
                            foreach (string line in sample.Read())
                            {
                                userInput.Add(line);
                            }
                            userInput.Add(Console.ReadLine());
                            sample.Write(userInput);
                            Console.WriteLine("Pievienot vel? y/n");
                            yesno = Console.ReadLine().ToUpper();
                        } while (yesno == "Y");
                        break;


                        // some indian code
                         case 4:
                        do{
                         
                        yesno = Console.ReadLine().ToUpper();
                        
                        List<string> userInput = new List<string>();  
                            foreach (string line in sample.Read())
                            {
                                userInput.Add(line);
                            }
                            Console.WriteLine("Enter new filename");
                            sample.filename = Console.ReadLine();
                            sample.Write(userInput);
                        } while (yesno == "Y");
                        
                        break;


                    case 5:
                        do
                        {
                            Console.WriteLine("Kadu elementu dzest no faila " + sample.filename + " ?");
                            List<string> tempList = sample.Read();
                            for (int i = 0; i < tempList.Count; i++)
                            {
                                Console.WriteLine(i + 1 + " " + tempList[i]);
                            }
                            int removeElement = Convert.ToInt32(Console.ReadLine());
                            tempList.RemoveAt(removeElement - 1);
                            sample.Write(tempList);
                            Console.WriteLine("Vel? y/n");
                            yesno = Console.ReadLine().ToUpper();
                        } while (yesno == "Y");
                        break;

                }


            }



            
        }


    }
}
