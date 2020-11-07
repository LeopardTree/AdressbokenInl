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
            List<Person> adressbok = new List<Person>();
            string command;
            Console.WriteLine("Välkommen till adressboken:");

            string path = "C:\\Users\\ludvi\\progmet\\adressbok.txt";
            string[] lines = File.ReadAllLines(@path);
            Console.WriteLine("Kontakter");
            Console.WriteLine();
            foreach (string line in lines)
            {
                //Console.WriteLine(line);
                string[] word = line.Split(',');
                //Console.WriteLine("{0} {1,-15}{2,-20}{3}", word[0], word[1], word[2], word[3]);
                adressbok.Add(new Person(word[0], word[1], word[2], word[3]));
            }
            for (int i = 0; i < adressbok.Count; i++)
            {
                if (adressbok[i] != null)
                {
                    Console.WriteLine("{0,-15} - {1,-15} - {2,-25} - {3}", adressbok[i].name, adressbok[i].phone, adressbok[i].email, adressbok[i].adress);
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
                    adressbok.Add(new Person(nM, pH, eM, aD));

                }
                else if (command == "visa")
                {
                    for(int i = 0; i < adressbok.Count; i++)
                    {
                        Console.WriteLine("{0,-15} - {1,-15} - {2,-25} - {3}", adressbok[i].name, adressbok[i].phone, adressbok[i].email, adressbok[i].adress);
                    }
                }
                else if (command == "ta bort")
                {
                    Console.Write("Vem vill du ta bort?");
                    string nM = Console.ReadLine();
                    for (int i = 0; i < adressbok.Count(); i++)
                    {
                        if (nM == adressbok[i].name)
                        {
                            
                            Console.WriteLine($" {nM} togs bort");
                            adressbok.RemoveAt(i);
                        }
                    }
                }

            } while(command != "avsluta");
            

            //stop
            //Console.ReadKey();
        }
    }
}
