using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace finalExam
{
    class Flight
    {
        public int Id;
        public string CityOfOrigin;
        public string CityOfDestination;
        public string dateOfDeparture;
        public string HourOfDeparture;
    }

    class Client
    {
        public int Id;
        public string UserName;
    }
    internal class Program
    {
        static Client[] clients = new Client[10];
        static Flight[] flights = new Flight[20];
        static int currentIndex = 0; // for Flight
        static int currentIndex2 = 0;// for client


        static void Main(string[] args)
        {
            while (true)
            {
                ShowMainManu();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateFlight();
                        break;
                    case 2:
                        CreateClient();
                        break;
                    case 3:
                        DisplayFlights();
                        break;
                    case 4:
                        DisplayClients();
                        break;
                    case 5:
                        ModifyOneClientById();
                        break;
                    case 6:
                        Console.WriteLine("Bye Bye..");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
               
            }
        }
        static void ShowMainManu()
        {
            Console.WriteLine("\nMy Travel");
            Console.WriteLine("1. Create one flight..");
            Console.WriteLine("2. Create one client..");
            Console.WriteLine("3. Display all the flights..");
            Console.WriteLine("4. Display all the clients..");
            Console.WriteLine("5. Modify one client..");
            Console.WriteLine("6. Exit the program..");
            Console.Write("Enter your Choice: ");
        }
        static void CreateFlight()
        {
            if (currentIndex < flights.Length)
            {
                Flight newFlight = new Flight();

                Console.WriteLine($"Enter flight id:{currentIndex + 1}");
                //   newFlight.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter City of origin:");
                newFlight.CityOfOrigin = Console.ReadLine();

                Console.WriteLine("Enter city of destinaton:");
                newFlight.CityOfDestination = Console.ReadLine();

                Console.WriteLine("Date of departure:");
                newFlight.dateOfDeparture = Console.ReadLine();

                Console.WriteLine("Hour of departure");
                newFlight.HourOfDeparture = Console.ReadLine();

                flights[currentIndex] = newFlight;
                currentIndex++;

                Console.WriteLine("Added succesfull...");
            }
            else
            {
                Console.WriteLine("Database is full....");
            }
        }
        static void CreateClient()
        {
            if (currentIndex2 < clients.Length)
            {
                Client newClient = new Client();
                Console.WriteLine($"Enter the client id: {currentIndex2 + 1}");
                //  newClient.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the client name: ");
                newClient.UserName = Console.ReadLine();

                clients[currentIndex2] = newClient;
                currentIndex2++;

                Console.WriteLine("Added succesfull...");
            }
            else
            {
                Console.WriteLine("Database is full");
            }
        }
        static void DisplayFlights()
        {
            Console.WriteLine("\nFlights details..");

            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine($"\nFlight {i + 1}");
                Console.WriteLine("City of origin : " + flights[i].CityOfOrigin);
                Console.WriteLine("City of destination : " + flights[i].CityOfDestination);
                Console.WriteLine("Date Of departure : " + flights[i].dateOfDeparture);
                Console.WriteLine("Hour of departure : " + flights[i].HourOfDeparture);
            }
        }
        static void DisplayClients()
        {
            Console.WriteLine("\nClients Details");
            for (int i = 0; i < currentIndex2; i++)
            {
                Console.WriteLine($"\nClient {i + 1}");
                Console.WriteLine("Client name :" + clients[i].UserName);
            }
        }
        static void ModifyOneClientById()
        {

            Console.Write("\nEnter the name of the Client you want to modify: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 1; i < currentIndex2; i++)
            {
                int indexFound = GetClientIndex(clients[i].Id);
                if (indexFound == -1)
                {
                    Console.WriteLine("This Client does not exists.");
                }
                else
                {
                    Console.WriteLine($"\nModify Client {clients[i].Id} - {clients[i].UserName}");

                    Console.WriteLine("Enter the new client name: ");
                    clients[i].UserName = Console.ReadLine();

                    Console.WriteLine("Added succesfull...");
                }



            }


        }
        private static int GetClientIndex(int id)
        {
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i].Id == id)
                {
                    return i;
                }
            }
            return -1;

        }
    }
}
