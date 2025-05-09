using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace p2
{

    struct Employee
    {
        public int Id;
        public string Password;
    }

    struct Client
    {
        public int Id;
        public string FullName;
        public string Password;
    }

    struct Book
    {
        public int Id;
        public string Name;
        public string Author;
        public int Year;
        public decimal UnitPrice;
        public int Quantity;
    }

    struct Sale
    {

        public int BookId;
        public int Quantity;
        public decimal TotalPrice;
        public DateTime SaleDate;
    }

    class Program
    {
        static Employee defaultEmployee = new Employee { Id = 111111, Password = "tester" };
        static Employee currentEmployee;
        static Client currentClient;
        static Book[] books = new Book[100];
        static Client[] clients = new Client[10];
        static int saleIndex = 0;
        static Sale[] sales = new Sale[1000];

        static void Main(string[] args)
        {
            InitializeDefaultData();

            while (true)
            {
                ShowMainMenu();
                int choice = GetChoice();
                switch (choice)
                {
                    case 1:
                        ClientSignIn();
                        break;
                    case 2:
                        EmployeeSignIn();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.Clear();
            }
        }

        static void InitializeDefaultData()
        {
            currentEmployee = defaultEmployee;

            for (int i = 0; i < 10; i++)
            {
                books[i].Id = 100000 + i;
                books[i].Name = $"Book{i + 1}";
                books[i].Author = $"Author{i + 1}";
                books[i].Year = 2020;
                books[i].UnitPrice = 20.0m;
                books[i].Quantity = 10;
            }

            clients[0].Id = 1000000;
            clients[0].FullName = "Customer1";
            clients[0].Password = "password";
        }

        static void ShowMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Client Sign In");
            Console.WriteLine("2. Employee Sign In");
            Console.WriteLine("3. Exit Application");
        }

        static int GetChoice()
        {
            Console.Write("Enter your choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Write("Invalid input. Enter a number: ");
            }
            return choice;
        }

        static void ClientSignIn()
        {
            Console.Write("Enter client ID: ");
            int clientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            currentClient = clients.FirstOrDefault(c => c.Id == clientId && c.Password == password);

            if (currentClient.Id != 0)
            {
                Console.WriteLine($"Welcome, {currentClient.FullName}!");

                while (true)
                {
                    ShowClientMenu();
                    int choice = GetChoice();

                    switch (choice)
                    {
                        case 1:
                            DisplayAllAvailableBooks();
                            break;
                        case 2:
                            DisplayPurchasedBooksByClient(currentClient.Id);
                            break;
                        case 3:
                            SignOut();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Invalid client ID or password.");
            }
        }

        static void DisplayAllAvailableBooks()
        {
            Console.WriteLine("Displaying all available books...");

            foreach (var book in books)
            {
                if (book.Id != 0 && book.Quantity > 0)
                {
                    Console.WriteLine($"Book ID: {book.Id}");
                    Console.WriteLine($"Name: {book.Name}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"Year of Publication: {book.Year}");
                    Console.WriteLine($"Unit Price: {book.UnitPrice:C}");
                    Console.WriteLine($"Quantity: {book.Quantity}");
                    Console.WriteLine(); // Empty line for readability
                }
            }
        }



        static void DisplayPurchasedBooksByClient(int clientId)
        {
            Console.WriteLine($"Books purchased by {currentClient.FullName}:");

            foreach (var sale in sales)
            {
                if (sale.BookId != 0 && sale.Quantity > 0 && sale.SaleDate != DateTime.MinValue && clientId == currentClient.Id)
                {
                    Book purchasedBook = books.FirstOrDefault(b => b.Id == sale.BookId);
                    if (purchasedBook.Id != 0)
                    {
                        Console.WriteLine($"Book ID: {purchasedBook.Id}");
                        Console.WriteLine($"Name: {purchasedBook.Name}");
                        Console.WriteLine($"Author: {purchasedBook.Author}");
                        Console.WriteLine($"Year: {purchasedBook.Year}");
                        Console.WriteLine($"Unit Price: {purchasedBook.UnitPrice:C}");
                        Console.WriteLine($"Quantity Purchased: {sale.Quantity}");
                        Console.WriteLine($"Total Price: {sale.TotalPrice:C}");
                        Console.WriteLine($"Sale Date: {sale.SaleDate}");
                        Console.WriteLine();
                    }
                }
            }
        }


        static void ShowClientMenu()
        {
            Console.WriteLine("Client Menu");
            Console.WriteLine("1. Display all available books");
            Console.WriteLine("2. Display the books I have purchased");
            Console.WriteLine("3. Sign Out");
        }

        static void EmployeeSignIn()
        {
            Console.Write("Enter employee ID: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (currentEmployee.Id == employeeId && currentEmployee.Password == password)
            {
                Console.WriteLine($"Welcome, Employee {currentEmployee.Id}!");

                while (true)
                {
                    ShowEmployeeMenu();
                    int choice = GetChoice();

                    // Implement employee functionalities based on choice

                    switch (choice)
                    {
                        case 1:
                            CreateClient();
                            break;
                        case 2:
                            ModifyClientById();
                            break;
                        case 3:
                            DisplayAllClients();
                            break;
                        case 4:
                            CreateBook();
                            break;
                        case 5:
                            ModifyBookById();
                            break;
                        case 6:
                            DisplayAllBooks();
                            break;
                        case 7:
                            SellBook();
                            break;
                        case 8:
                            DisplayTotalBooksSold();
                            break;
                        case 9:
                            DisplayTotalSales();
                            break;
                        case 10:
                            ClientSignIn();
                            break;
                        case 11:
                            SignOut();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Invalid employee ID or password.");
            }
        }

        static void ShowEmployeeMenu()
        {
            Console.WriteLine("Employee Menu");
            Console.WriteLine("1. Create a client");
            Console.WriteLine("2. Modify one client by ID");
            Console.WriteLine("3. Display all the clients");
            Console.WriteLine("4. Create a book");
            Console.WriteLine("5. Modify one book by ID");
            Console.WriteLine("6. Display all the books");
            Console.WriteLine("7. Sell a book");
            Console.WriteLine("8. Display all the books sold");
            Console.WriteLine("9. Display total of sales");
            Console.WriteLine("10. Jump to Client Area ");
            Console.WriteLine("11. Sign Out");
        }

        static void CreateClient()
        {
            Console.WriteLine("Creating New Client...");
            Console.WriteLine("Enter Clients ID: ");
            int clientId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Client Fullname: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter Client password: ");
            string password = Console.ReadLine();

            int nextIndex = FindNextIndex();

            if (nextIndex != -1)
            {
                clients[nextIndex] = new Client { Id = clientId, FullName = fullName, Password = password };
                Console.WriteLine("Client added successfully....");
            }
            else
            {
                Console.WriteLine("Unable to add client. Array is full.");
            }

        }

        static int FindNextIndex()
        {
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i].Id == 0)
                {
                    return i;
                }

            }
            return -1;
        }

        static void ModifyClientById()
        {
            Console.WriteLine("Modifying client by id.....");

            Console.WriteLine("Enter Client Id to modify: ");
            int clientId = Convert.ToInt32(Console.ReadLine());

            Client clientToModify = clients.FirstOrDefault(c => c.Id == clientId);// error here

            if (clientToModify.Id != 0)
            {
                Console.WriteLine($"Current Full Name: {clientToModify.FullName}");
                Console.WriteLine($"Current Password: {clientToModify.Password}");

                Console.Write("Enter new full name (press Enter to keep current): ");
                string newFullName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newFullName))
                {
                    clientToModify.FullName = newFullName;
                }

                Console.Write("Enter new password (press Enter to keep current): ");
                string newPassword = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newPassword))
                {
                    clientToModify.Password = newPassword;
                }

                Console.WriteLine("Client information updated successfully!");
            }
            else
            {
                Console.WriteLine("Client not found.");
            }
        }

        static void DisplayAllClients()
        {
            Console.WriteLine("Displaying all clients...");

            foreach (var client in clients)
            {
                if (client.Id != 0)
                {
                    Console.WriteLine($"Client Id: {client.Id}");
                    Console.WriteLine($"Full name: {client.FullName}");
                    Console.WriteLine();
                }
            }
        }

        static void CreateBook()
        {
            Console.WriteLine("Creating a book...");

            Console.WriteLine("Enter Book ID: ");
            int bookId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter book name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter book Author: ");
            string author = Console.ReadLine();

            Console.WriteLine("Enter year of publiction: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price : ");
            decimal unitPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            int nextIndex = FindNextIndexBooks();

            if (nextIndex != -1)
            {
                books[nextIndex] = new Book
                {
                    Id = bookId,
                    Name = name,
                    Author = author,
                    Year = year,
                    Quantity = quantity,
                    UnitPrice = unitPrice
                };
                Console.WriteLine("Books added successfully");
            }
            else
            {
                Console.WriteLine("Unable to add book. Array is full.");
            }
        }

        static int FindNextIndexBooks()
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Id == 0)
                {
                    return i; // Return the index of the first null element
                }
            }
            return -1;
        }

        static void ModifyBookById()
        {
            Console.WriteLine("Modifying a book...");

            Console.Write("Enter book ID to modify: ");
            int bookId = Convert.ToInt32(Console.ReadLine());

            // Find the book based on ID
            Book book = books.FirstOrDefault(b => b.Id == bookId);

            if (book.Id != 0)
            {

                Console.Write("Enter new name: ");
                string newName = Console.ReadLine();

                Console.Write("Enter new author: ");
                string newAuthor = Console.ReadLine();

                Console.Write("Enter new year of publication: ");
                int newYear = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter new unit price: ");
                decimal newUnitPrice = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter new quantity: ");
                int newQuantity = Convert.ToInt32(Console.ReadLine());

                // Update book details
                book.Name = newName;
                book.Author = newAuthor;
                book.Year = newYear;
                book.UnitPrice = newUnitPrice;
                book.Quantity = newQuantity;

                Console.WriteLine("Book modified successfully!");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        static void DisplayAllBooks()
        {
            Console.WriteLine("Displaying All the books....");

            foreach (var book in books)
            {
                if (book.Id != 0)
                {
                    Console.WriteLine($"Book Id: {book.Id}");
                    Console.WriteLine($"Name: {book.Name}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"Year of Publication{book.Year}");
                    Console.WriteLine($"Unit Price: {book.UnitPrice:C}");
                    Console.WriteLine($"Quantity: {book.Quantity}");
                }
            }
        }

        static void SellBook()
        {
            Console.WriteLine("Selling a book...");

            Console.Write("Enter client ID: ");
            int clientId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter book ID to sell: ");
            int bookId = Convert.ToInt32(Console.ReadLine());

            // Find the client and book based on IDs
            Client client = clients.FirstOrDefault(c => c.Id == clientId);
            Book book = books.FirstOrDefault(b => b.Id == bookId);

            if (client.Id != 0 && book.Id != 0 && book.Quantity > 0)
            {
                Console.Write("Enter quantity to sell: ");
                int quantityToSell = Convert.ToInt32(Console.ReadLine());

                if (quantityToSell > 0 && quantityToSell <= book.Quantity)
                {
                    // Calculate total price
                    decimal totalPrice = quantityToSell * book.UnitPrice;

                    // Update book quantity
                    book.Quantity -= quantityToSell;

                    // Record the sale in the sales array
                    Sale newSale = new Sale
                    {
                        BookId = bookId,
                        Quantity = quantityToSell,
                        TotalPrice = totalPrice,
                        SaleDate = DateTime.Now
                    };

                    sales[saleIndex] = newSale;
                    saleIndex++;

                    Console.WriteLine($"Book sold successfully. Total price: {totalPrice:C}");
                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please enter a valid quantity.");
                }
            }
            else
            {
                Console.WriteLine("Client or book not found, or book not available.");
            }
        }

        static void DisplayTotalBooksSold()
        {
            Console.WriteLine("Displaying all books sold...");

            foreach (var sale in sales)
            {
                if (sale.BookId != 0) // Check if sale exists (Book ID is not zero)
                {
                    Console.WriteLine($"Book ID: {sale.BookId}");
                    Console.WriteLine($"Quantity Sold: {sale.Quantity}");
                    Console.WriteLine($"Total Price: {sale.TotalPrice:C}"); // Format price as currency
                    Console.WriteLine($"Sale Date: {sale.SaleDate}");
                    Console.WriteLine(); // Empty line for readability
                }
            }
        }

        static void DisplayTotalSales()
        {
            decimal totalSales = 0;
            foreach (Sale sale in sales)
            {
                if (sale.BookId != 0)
                {
                    totalSales += sale.TotalPrice;
                }
            }
            Console.WriteLine($"Total sales: {totalSales:c}");
        }

        static void SignOut()
        {
            Console.WriteLine("Signing out...");

            Console.WriteLine("Signed out successfully....");

            Environment.Exit(0);
        }
    }

}


