using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using LabTwo;

class Program
{
    static void Main(string[] args)
    {
        BookStore bookStore = new BookStore();
        ItemSearch itemSearch = new ItemSearch();
        LoanStore loanStore = new LoanStore();
        DVDStore dVDStore = new DVDStore();  
        MemberStore memberStore = new MemberStore();
        // PaymentRequest paymentRequest = new PaymentRequest();
        //Loan loan = new Loan();
        // Member member = new Member();
        //Book book = new Book();
        // DVD dVD = new DVD();
        //Item item = new Item();

        while (true)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Welcome to the Library Manager!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add a new book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. List all books");
            Console.WriteLine("4. Search books by author");
            Console.WriteLine("5. Search books by ISBN");
            Console.WriteLine("6. Add a new DVD");
            Console.WriteLine("7. Remove a DVD");
            Console.WriteLine("8. List all DVDs");
            Console.WriteLine("9. Search DVDs by director");
            Console.WriteLine("10. Search items by Title");
           
            Console.WriteLine("11. list of items");
            Console.WriteLine("12. Add Member");
            Console.WriteLine("13. Remove member ");
            Console.WriteLine("14. list of members");
            Console.WriteLine("15. crerate loan");
            Console.WriteLine("16. close loan ");
            Console.WriteLine("17. list loans of member");
            Console.WriteLine("18. Search items by Barcode ");
            Console.WriteLine("20. Exit");

            // Read user input
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (option)
            {
                case 1:
                    // Add new book code here
                    bookStore.AddNewBook();
                 
                    break;

                case 2:
                    // Remove book code here
                    bookStore.RemoveBook();
                    break;

                case 3:
                    // List all books code here
                    List<Book> savedBooks = bookStore.ListBooks();

                    foreach (Book book in savedBooks)
                    {
                        Console.WriteLine($"{book.Title} by {book.Author}, ISBN: {book.ISBN}");
                    }
                    break;

                case 4:
                    // Search books by author code here
                    Console.Write("Enter author name: ");
                    string author = Console.ReadLine();

                    bookStore.SearchBooksByAuthor(author);
                    break;

                case 5:
                    // Search books by ISBN code here
                    Console.WriteLine("Enter the ISBN of book to search for");
                    string isbn = Console.ReadLine();

                   
                    bookStore.SearchBookByISBN(isbn);
                    break;

                case 6:
                    // Add new DVD code here
                    dVDStore.AddNewDVD();
                    break;
                case 7:
                    // Remove DVD code here
                    dVDStore.RemoveDVD();
                    break;
                case 8:
                    // List all DVDs code here

                    List<DVD> savedDVDs = dVDStore.ListDVDs();

                    foreach (DVD dvd in savedDVDs)
                    {
                        Console.WriteLine($"{dvd.Title} by {dvd.Director}");
                    }

                    break;
                case 9:
                    // Search DVDs by director code here
                    Console.Write(" Enter the Director of DVD for search: ");
                    string director = Console.ReadLine();
                    dVDStore.SearchDVDByDirector(director);
                    break;

                case 10:
                    // search items by title
                    itemSearch.SearchByTitle();
                    break;
                case 11:
                    // List all items
                    List<Item> savedItems = itemSearch.ListItems();

                    foreach (Item item in savedItems)
                    {
                        Console.WriteLine($"{item.Title} by {item.Barcode}");
                    }
                    break;

                case 12:
                    // Add new member
                    Console.WriteLine("enter name :");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter id :");
                    string id = Console.ReadLine();
                    memberStore.AddMember(id, name);

                    break;
                case 13:
                    // remove member                  
                    memberStore.RemoveMember();
                    break;
                case 14:
                    // list of members
                    List<Member> savedMembers = memberStore.ListMembers();

                    foreach (Member member in savedMembers)
                    {
                        Console.WriteLine($"Name: {member.Name} , Id: {member.Id}");
                    }
                    break;
                case 15:
                    // create loan
                    Console.WriteLine("Enter member id ");
                    string MemberId = Console.ReadLine();
                    List<Member> matchedMember = memberStore.GetMemberByID(MemberId);

                    Console.WriteLine("enter item titel  :");
                    string itemTitle = Console.ReadLine();
                    List<Item> matchedItem = itemSearch.GetItemByTitle(itemTitle);
                    //loanStore.CreateNewLoan(matchedMember, matchedItem);
                    break;
                case 16:
                    // close loan
                    //loanStore.CloseLoan();
                    break;

                case 18:
                    // search items by barcode
                    itemSearch.SearchByBarcode();
                    break;
                case 20:
                    Console.WriteLine("Exiting program...");
                    Environment.Exit(0);
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }


        }
       
    }
}