using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

namespace LabTwo
{

    public class ItemSearch
    {

        //private List<Item> items;

        //public ItemSearch()
        //{
        //    items = new List<Item>();
        //}
        public List<Item> items = new List<Item>();


        public Item[] SearchByTitle()
        {
            Console.WriteLine("Enter Item title :");
            string itemTitle = Console.ReadLine();
            List <Item> results = new List<Item>();

            foreach (Item item in items)
            {
              
                if (item.Title.Contains(itemTitle))
                {
                    results.Add(item);
                }
                
            }
            if (results.Count == 0)
            {
                Console.WriteLine("No items found with title '{0}'", itemTitle);
            }
            else
            {
                Console.WriteLine("items found with title '{0}':", itemTitle);
                foreach (Item item in results)
                {
                    Console.WriteLine($"{item.Title} by {item.Barcode}");
                }
            }

            return results.ToArray();
        }

        public Item[] SearchByBarcode()
        {
            Console.WriteLine("Enter Item barcode  :");
            int itemBarcode = Convert.ToInt32(Console.ReadLine());
            List<Item> results = new List<Item>();

            foreach (Item item in items)
            {
                if (item.Barcode == itemBarcode)
                {
                    results.Add(item);
                }
            }
            if (items.Count == 0)
            {
                Console.WriteLine("No items found ");
            }
            else
            {
                Console.WriteLine("items found ");
                foreach (Item item in results)
                {
                    Console.WriteLine($"Title: {item.Title} , Barcode {item.Barcode}");
                }
            }

            return results.ToArray();



        }


        public List<Item> ListItems()
        {
            Console.WriteLine("List of stored Items:");
            return items;
        }

        public List<Item> GetItemByTitle(string itemTitle)
        {
        
            List<Item> matcheditems = new List<Item>();
            foreach (Item item in items)
            {
                if (item.Title == itemTitle)
                {
                    matcheditems.Add(item);
                }
            }

            if (matcheditems.Count == 0)
            {
                Console.WriteLine("No item found with Title '{0}'", itemTitle);
            }

            return matcheditems;
        }
    }


}

