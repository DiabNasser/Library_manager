using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
namespace LabTwo
{
    public class DVD:Item
    {
        //internal static readonly IEnumerable<DVD> DVDs;

        public string Director { get; set; }


        public DVD(string title, int barcode, string director)
            : base(title, barcode)
        {
            Director = director;
        }



    }
}

