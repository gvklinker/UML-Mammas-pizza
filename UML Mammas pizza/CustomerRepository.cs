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
    }
}
