using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace LabTwo
{
    public class Item
    {
       
        

        public string Title { get; set; }
        public int Barcode { get; set; }
        public bool IsAvailable { get; set; }

        public Item(string title, int barcode)
        {
            Title = title;
            Barcode = barcode;
            IsAvailable = true;
        }
        public void SetStatus(bool status)
        {
            IsAvailable = status;
        }
        //public bool IsAvailable()
        //{
        //    // Code to check if item is available
        //    return true;
        //}
    }

}

