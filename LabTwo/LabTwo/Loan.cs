using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Metrics;
using static System.Reflection.Metadata.BlobBuilder;

namespace LabTwo
{
    public class Loan
    {
        public DateTime BorrowDate { get; }
        public DateTime DueToDate { get; }
        public Item Item { get; }
        public Member Member { get; }
        public bool IsClosed { get; private set; }
        public PaymentRequest PaymentRequest { get; private set; }

        public Loan(Member member, Item item, DateTime borrowDate, DateTime dateTime)
        {
            BorrowDate = DateTime.Today;
            DueToDate = DateTime.Today.AddDays(14);
            Member = member;
            Item = item;
            IsClosed = false;
        }

        public void Close()
        {
            IsClosed = true;
          
        }
    }


}

