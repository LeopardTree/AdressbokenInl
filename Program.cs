using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdressbokenInl
{
    class Program
    {
        class Person
        {
            public string name, phone, email, adress;

            public Person(string nM, string pH, string eM, string aD)
            {
                name = nM;
                phone = pH;
                email = eM;
                adress = aD;
            }
        }
        static void Main(string[] args)
        {
            List<Person> adressbook = new List<Person>();
            string command;
            Console.WriteLine("Välkommen till adressboken:");

            string path = "C:\\Users\\ludvi\\progmet\\adressbok.txt";
            string pathtest = "C:\\Users\\ludvi\\progmet\\adressboktest.txt";
            string[] lines = File.ReadAllLines(@path);
            Console.WriteLine("Kontakter");
            Console.WriteLine();
            foreach (string line in lines)
            {
                //Console.WriteLine(line);
                string[] word = line.Split(',');
                //Console.WriteLine("{0} {1,-15}{2,-20}{3}", word[0], word[1], word[2], word[3]);
                adressbook.Add(new Person(word[0], word[1], word[2], word[3]));
                
            }
            for (int i = 0; i < adressbook.Count; i++)
            {
                if (adressbook[i] != null)
                {
                    Console.WriteLine("{0,-15} - {1,-15} - {2,-25} - {3}", adressbook[i].name, adressbook[i].phone, adressbook[i].email, adressbook[i].adress);
                    Console.WriteLine("");
                }
            }
            //Console.WriteLine("------------------");

            Console.WriteLine();
            Console.WriteLine("Navigera med kommandona: lägg till, ta bort, spara, visa, ändra och avsluta");
            
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                if (command == "lägg till")
                {
                    Console.Write("Vem vill du lägga till? ");
                    string nM = Console.ReadLine();
                    Console.Write($"Vad har {nM} för telefonnummer?");
                    string pH = Console.ReadLine();
                    Console.Write($"Vad har {nM} för email?");
                    string eM = Console.ReadLine();
                    Console.Write($"Vad har {nM} för adress?");
                    string aD = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine($"{nM} med {pH}, {eM} på adressen {aD} har lagts till i adressboken!");
                    adressbook.Add(new Person(nM, pH, eM, aD));
                    

                }
                else if (command == "visa")
                {
                    for(int i = 0; i < adressbook.Count; i++)
                    {
                        Console.WriteLine("{0,-15} - {1,-15} - {2,-25} - {3}", adressbook[i].name, adressbook[i].phone, adressbook[i].email, adressbook[i].adress);
                    }
                }
                else if (command == "ta bort")
                {
                    Console.Write("Vem vill du ta bort?");
                    string nM = Console.ReadLine();
                    for (int i = 0; i < adressbook.Count(); i++)
                    {
                        if (nM == adressbook[i].name)
                        {
                            Console.WriteLine($" {nM} togs bort");
                            adressbook.RemoveAt(i);
                        }
                    }
                }
                else if(command == "spara")
                {

                    string[] arrayAdressbook = new string[adressbook.Count];
                    for(int i = 0; i < adressbook.Count; i++)
                    {
                        arrayAdressbook[i] = adressbook[i].name + ", " + adressbook[i].phone + ", " + adressbook[i].email + ", " + adressbook[i].adress;
                    }
                    File.WriteAllLines(path, arrayAdressbook);
                    //Console.WriteLine("ändringarna är nu sparade");

                    // Example #1: Write an array of strings to a file.
                    // Create a string array that consists of three lines.
                    //string[] lines = { "First line", "Second line", "Third line" };
                    //// WriteAllLines creates a file, writes a collection of strings to the file,
                    //// and then closes the file.  You do NOT need to call Flush() or Close().
                    //System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);

                    //System.IO.File.WriteAllLines("SavedLists.txt", Lists.verbList);
                }

            } while(command != "avsluta");
            

            //stop
            //Console.ReadKey();
        }
    }
}
