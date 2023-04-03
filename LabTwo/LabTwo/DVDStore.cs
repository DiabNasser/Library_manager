using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;

namespace LabTwo
{

    public class DVDStore
    {
        public List<DVD> dvds = new List<DVD>();
        List<Item> items = new List<Item>();

        public DVDStore()
        {
           
        }

        public void AddNewDVD()
        {
            Console.WriteLine("Enter DVD details:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Director: ");
            string director = Console.ReadLine();

            int barcode = GetNewBarcode();
            DVD dvd = new DVD(title, barcode, director);
            dvds.Add(dvd);
            Item newItem = new Item(title, barcode);
            items.Add(newItem);
            Console.WriteLine("DVD added successfully.");
        }

        public void RemoveDVD()
        {
            Console.Write(" Enter the Director of DVD to remove: ");
            string director = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < dvds.Count; i++)
            {
                if (dvds[i].Director == director )
                {
                    dvds.RemoveAt(i);
                 
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("DVD removed successfully.");
            }
            else
            {
                Console.WriteLine("DVD not found.");
            }
        }

        public void SearchDVDByDirector(string director)
        {


            List<DVD> matchedDVDs = new List<DVD>();
            foreach (DVD dvd in dvds)
            {
                if (dvd.Director == director)
                {
                    matchedDVDs.Add(dvd);
                }
            }

            if (matchedDVDs.Count == 0)
            {
                Console.WriteLine("No DVDs found with director '{0}'", director);
            }
            else
            {
                Console.WriteLine("DVDs found with director '{0}':", director);
                foreach (DVD dvd in matchedDVDs)
                {
                    Console.WriteLine($"{dvd.Title} with Director: {dvd.Director}");
                }
            }
        }
     

         public List<DVD> ListDVDs()
         {
               Console.WriteLine("List of stored DVDs:");
               return dvds;
         }

            private int GetNewBarcode()
        {
            // Code to generate new barcode goes here
            return 0;
        }
    }

}

