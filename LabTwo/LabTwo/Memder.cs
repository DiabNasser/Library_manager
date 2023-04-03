using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;


namespace LabTwo
{
    public class Member
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Loan> Loans { get; set; }
        public PaymentRequest PaymentRequest { get; set; }

        public Member(string id, string name)
        {
            Id = id;
            Name = name;
            Loans = new List<Loan>();
        }
   

        public bool HasOngoingPaymentRequest()
        {
            // logic to check if member has an ongoing payment request
            return PaymentRequest != null && PaymentRequest.DueToDate >= DateTime.Today;
        }

        public void FulfilPaymentRequest(PaymentRequest request)
        {
            PaymentRequest = null;
        }
    }

}

