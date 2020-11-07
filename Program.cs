using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AdressbokenInl
{
    class Program
    {
        class Person
        {
            public string forename, lastname, phone, email, adress;

            public Person(string fN, string lN, string pH, string eM, string aD)
            {
                forename = fN;
                lastname = lN;
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
            Console.WriteLine("{0,-10}{1,-20}{2,-30}{3,-40}{4,-50}",
                                        "Förnamn", "Efternamn", "Telefon", "Email", "Adress");
            Console.WriteLine("------------------");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                //string[] word = line.Split(', ');
                //Console.WriteLine("{0} - {1}", word[0], word[1]);
                //dict.Add(new DictEntry(word[0], word[1]));
            }
            //for (int i = 0; i < dict.Count; i++)
            //{
            //    if (dict[i] != null)
            //    {
            //        Console.WriteLine("{0,-10}{1,-20}", dict[i].english, dict[i].swedish);
            //    }
            //}
            //Console.WriteLine("------------------");

            Console.WriteLine();
            Console.WriteLine("Navigera med kommandona: lägg till, ta bort, spara, ändra och avsluta");
            
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();

            } while(command != "sluta");

            //stop
            Console.ReadKey();
        }
    }
}
