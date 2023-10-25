using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Mammas_pizza
{
    class CustomerRepository
    {

        private Dictionary<string, Customer> _customers;
        public CustomerRepository() {
            _customers = new Dictionary<string, Customer>();
        }

        public int Count {  get { return _customers.Count; } }

        public Customer? FindCustomer(string username) {
            if(_customers.ContainsKey(username))
                return _customers[username];
            return null;
        }

        public bool AddCustomer(Customer customer)
        {
            return _customers.TryAdd(customer.UserName, customer);
            //int check = _customers.Count;
            //_customers.Add(customer.UserName, customer);
            //return check < _customers.Count; //If the customer were added to the dictionary, then the number of customers should have increased
        }

        public bool DeleteCustomer(string username)
        {
            return _customers.Remove(username);
        }

        public void UpdateCustomer(string username, Customer updatedCus) {
            //if(!_customers.Remove(username))
            //    return false;
            //return _customers.TryAdd(updatedCus.UserName, updatedCus);
            _customers[username] = updatedCus;
        }

        public void PrintCustomers()
        {
            foreach (var item in _customers)
            {
                Console.WriteLine(item.Value.ToString());
            }
        }

        public void Setup()
        {
            Customer c1 = new Customer("Alex56", "Alex Lempert", "AL@gmil.com", "24252627", "Oxford", "43270", "Gray Road", 64);
            Customer c2 = new Customer("D54", "Dennis Wallard", "D54@mail.dk", "12541254", "London", "32542", "That street", 76);
            Customer c3 = new Customer("Qwerty", "Alice Gaul", "gualmaul@Gmail.com", "54321987", "Aarhus", "8000", "Badstræde", 15);
            _customers.Add(c1.UserName, c1);
            _customers.Add(c2.UserName, c2);
            _customers.Add(c3.UserName, c3);
        }
    }
}
