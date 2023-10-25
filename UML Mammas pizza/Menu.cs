using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Mammas_pizza
{
    class Menu
    {
        private PizzaRepository pizRepo;
        private CustomerRepository cusRepo;

        public Menu()
        {
            pizRepo = new PizzaRepository();
            cusRepo = new CustomerRepository();
        }

        private int ReadUserChoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
                return input;
            else
                return -1;
        }
        private int ShowMenu() {
            Console.WriteLine("\t   ******Big Mamma's Pizza******");
            Console.WriteLine("\t****** What can we do for you? ******");
            Console.WriteLine("\t1. New user? Get started here");
            Console.WriteLine("\t2. Find a user");
            Console.WriteLine("\t3. Delete a user");
            Console.WriteLine("\t4. Update a user");
            Console.WriteLine("\t5. Display current users");
            Console.WriteLine("\t****** Pizza ******");
            Console.WriteLine("\t6. Add a pizza to the menu");
            Console.WriteLine("\t7. Remove a pizza from the menu");
            Console.WriteLine("\t8. Update a pizza");
            Console.WriteLine("\t9. Display all pizzas");
            Console.WriteLine("\t");
            Console.WriteLine("\t");
            Console.WriteLine("\t0 to exit the program");
            return ReadUserChoice();
        }

        public void Run()
        {
            int choice = ShowMenu();
            while(choice != 0)
            {
                switch(choice){
                    case 1: AddToCus(); break;
                    case 2: FindCus(); break; 
                    case 3: RemoveFromCus(); break;
                    case 4: UpdateCus(); break;
                    case 5: DisplayCus();  break;
                    case 6: AddPiz(); break;
                    case 7: RemovePiz(); break;
                    case 8: UpdatePiz();  break;
                    case 9: DisplayPiz();  break;
                    case 11: cusRepo.Setup(); break;
                    case 12: pizRepo.Setup(); break;
                    default: ErrorMessage(); break;
                }
                Console.ReadLine();
                Console.Clear();
                choice = ShowMenu();
            }
        }

        private void AddToCus()
        {
            Console.WriteLine("You are trying to create a new user");
            Customer cus = CreateCustomer();
            if (cusRepo.AddCustomer(cus))
                Console.WriteLine($"Welcome {cus.UserName}, you are now in the system");
            else 
                Console.WriteLine($"Username: {cus.UserName} is already in use, please try again");
        }
        private void RemoveFromCus() {
            Console.WriteLine("You are trying to delete a user");
            string username = GetUsername();
            if (cusRepo.DeleteCustomer(username))
                Console.WriteLine($"User: {username} has been deleted");
            else
                Console.WriteLine($"{username} is not in the system, so it can't be deleted");
        }
        private void FindCus()
        {
            Console.WriteLine("You are trying to find a user");
            string username = GetUsername();
            Customer cus = cusRepo.FindCustomer(username);
            Console.WriteLine(cus.ToString());
        }
        private void UpdateCus() {
            Console.WriteLine("You are trying to update a users info");
            string username = GetUsername();
            Customer cus = CreateCustomer();
            cusRepo.UpdateCustomer(username, cus);
            Console.WriteLine(cus.ToString());
            Console.WriteLine("Has been changed to:");
            Console.WriteLine(cusRepo.FindCustomer(username).ToString());
        }
        private void DisplayCus() {
            Console.WriteLine("Displaying all users");
            cusRepo.PrintCustomers();
        }
        private void AddPiz() {  } 
        private void RemovePiz() {
            Console.WriteLine("You are trying to delete a pizza");
            string num = GetThatNumber();
            if (pizRepo.DeletePizza(num))
                Console.WriteLine($"User: {num} has been deleted");
            else
                Console.WriteLine($"{num} is not in the system, so it can't be deleted");
        }
        private void UpdatePiz() { }
        private void DisplayPiz() {
            pizRepo.PrintPiz();
        }

        private string GetUsername()
        {
            Console.WriteLine("Type in a username");
            return Console.ReadLine();
        }

        private string GetThatNumber() { 
            Console.WriteLine("What is the number of the pizza?");
            return Console.ReadLine();
        }

        private void ErrorMessage()
        {
            Console.WriteLine("Invalid input, please try again");
        }

        private Customer CreateCustomer() {
            string username = GetUsername();
            Console.WriteLine("Type in your name");
            string name = Console.ReadLine();
            Console.WriteLine("Type in your e-mail");
            string email = Console.ReadLine();
            Console.WriteLine("Type in your phone number");
            string phone = Console.ReadLine();
            Console.WriteLine("Type in your city");
            string city = Console.ReadLine();
            Console.WriteLine("Type in your zip code");
            string zip = Console.ReadLine();
            Console.WriteLine("Type in your street name");
            string street = Console.ReadLine();
            Console.WriteLine("Type in your street number");
            int num = int.Parse(Console.ReadLine());
            return new Customer(username, name, email, phone, city, zip, street, num);
        }

        private Pizza CreatePizza()
        {
            List<Topping> toppings = new List<Topping>() { new Topping("Cheese", 0, true), new Topping("Tomato", 0, true)};
            string num = GetThatNumber();
            Console.WriteLine("What is this pizza going to be called?");
            string name = Console.ReadLine();
            Console.WriteLine("What is it going to cost?");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("What should be on this pizza?");
            int choice = PickTopping();
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        toppings.Add(new Topping("Ham", 7, false)); break;
                    case 2:
                        toppings.Add(new Topping("Mushroom", 5, true)); break;
                    default: Console.WriteLine(""); break;
                }
            }
            return new Pizza(toppings, num, name, price);
        }

        private int PickTopping()
        {
            return ReadUserChoice();
        }
    }
}
