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

            } while(command != "sluta");

            //stop
            Console.ReadKey();
        }
    }
}
