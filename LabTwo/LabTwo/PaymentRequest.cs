using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
namespace LabTwo
{
    public class PaymentRequest
    {
        public int Amount { get; set; }
        public DateTime DueToDate { get; set; }

        public PaymentRequest(int amount, DateTime dueToDate)
        {
            Amount = amount;
            DueToDate = dueToDate;
        }

    }

}

