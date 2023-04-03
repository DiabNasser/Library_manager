using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace LabTwo
{

    public class LoanStore
    {
        public List<Loan> loans = new List<Loan>();

        public void CreateNewLoan(Member member, Item item)
        {
            //if (!member.HasOngoingPaymentRequest() && item.IsAvailable)
            //{
               // item.SetStatus(false);
                DateTime borrowDate = DateTime.Now;
                DateTime dueToDate = borrowDate.AddDays(14);
                Loan loan = new Loan(member, item, borrowDate, dueToDate);
                loans.Add(loan);
            //}
        }

        public void CloseLoan(Loan loan)
        {
            loan.Item.SetStatus(true);
           // loan.IsClosed = true;
            if (DateTime.Now > loan.DueToDate)
            {
                CreatePaymentRequest(loan.Member);
            }
        }

        public List<Loan> ListLoansForMember(Member member)
        {
            return loans.Where(l => l.Member == member).ToList();
        }

        public void CreatePaymentRequest(Member member)
        {
          //  PaymentRequest paymentRequest = new PaymentRequest(member);
           // member.FulfilPaymentRequest(paymentRequest);
        }
    }


}

