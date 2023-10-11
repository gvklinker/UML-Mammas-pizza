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
            {
                return input;
            }
            else
            {
                return -1;
            }
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
                    default: break;
                }
                Console.Clear();
                Console.ReadLine();
                choice = ShowMenu();
            }
        }

        private void AddToCus()
        {

        }
        private void RemoveFromCus() { }
        private void FindCus()
        {

        }
        private void UpdateCus() { }
        private void DisplayCus() { }
        private void AddPiz() {  } 
        private void RemovePiz() { }
        private void UpdatePiz() { }
        private void DisplayPiz() { }
    }
}
