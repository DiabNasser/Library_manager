using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;


namespace LabTwo
{
    public class Book:Item
    {
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, int barcode, string author, string isbn)
         : base(title, barcode)
        {
            Author = author;
            ISBN = isbn;
        }
    }
}

