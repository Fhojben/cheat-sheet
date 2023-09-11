using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cheat_sheet
{
    internal class Program
    {


    static void Main(string[] args)
        {

            Console.Write("tekst"); // skriver teksten i consolen
            Console.WriteLine("tekst") //skriver teksten i consolen med en enter i slutningen
            int x = 10; //giver en værdi som er hel
            double y = 1,5; //giver en værdi som ikke er lige
            double result = x + y; //kan lave matematik og hvise komma tal + * - /
            bool værdi = true; // kan sætte en værdi til falsk eller rigtig

            Console.ReadKey(); // consolen venter på at der bliver trykket på en knap

            string Usertekst = Console.ReadLine(); // difinere en variabel som en sting

            int Usertal = int.Parse(Console.ReadLine()); // difinere en variabel som et tal fra consolen

            % // modulus er rasten der er tilbage efetr at have divideret noget


            /* komentar */        //      gør alt fra /* til */ til en komentar

            

           



            List<int> list = new List<int>(); // laver en list med navnet "list" som er en liste med hele tal (int) kan også være andre ting
            list.Add(Usertal); // tilføre et tal til listen


            if (x == 10) // hvis x er lig med 10 kør den her kode
            {

            }
            else if (x == 15) // hvis x ikke er lig 10 men lig 15 kør den her kode
            {

            }
            else // hvis x ikke er lig 10 eller 15 kør den her kode
            { 
            
            }

            if (x == 10 || x == 15) // hvis x er lig med 10 ELLER 15 kør den her kode
            { 
            
            }
            if(x == 10 && x == 15) // hvis x er lig med 10 OG 15 kør den her kode
            {

            }

            while (værdi == true) // kør den her kode imens værdi er lig true (Kan også være matematik)
            { 
            
            }

            // FIND FEJL-----------------------------

            // hvis der bliver fundet en fejl køre den fra toppen af try igen intil at det virker.
            try // kør den her kode
            {
                string UserInput = Console.ReadLine();
                int UserNumber = int.Parse(UserInput);


                if (UserNumber < 0) // hvis tallet er mindre end 0 kør den her kode
                {
                    throw new ArgumentOutOfRangeException(); // Smidder os ned til catch (ArgumentOutOfRangeException e)
                }
               
            }
            catch (ArgumentOutOfRangeException e) // hvis vi finder fejlen ArgumentOutOfRangeException kør den her kode
            {
                Console.WriteLine("Forkærte input skriv et positivt nummer! Prøv igen.");
            }
            catch (FormatException e) // hvis vi finder fejlen FormatException kør den her kode
            {
                Console.WriteLine("Forkærte input skriv et nummer! Prøv igen.");

            }
            catch (Exception e)  // hvis vi finder fejlen Exception kør den her kode (Exception er ALLE fejl som der er)
            {
                Console.WriteLine("Uforventet fejl! Prøv igen.");
            }
        }
}
