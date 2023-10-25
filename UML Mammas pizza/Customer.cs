using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Mammas_pizza
{
    class Customer
    {
        private string _userName;
        private string _name;
        private string _email;
        private string _phone;
        private string _city;
        private string _zip;
        private string _street;
        private int _streetNum;

        public Customer(string user, string name, string email, string phone, string city, string zip, string street, int streetNum) {
            _userName = user;
            _name = name;
            _email = email;
            _phone = phone;
            _city = city;
            _zip = zip;
            _street = street;
            _streetNum = streetNum;
        }

        public string UserName { get { return _userName; } }
        public string Name { get { return _name; } }
        public string Email { get { return _email; } }
        public string Phone { get { return _phone; } }
        public string Adress { get { return $"{_street} {_streetNum}, {_city} {_zip}"; } }

        public override string ToString()
        {
            return $"Uesr: {_userName}, Name: {_name}, E-mail: {_email}, Phone number: {_phone}, Adress: {Adress}";
        }

    }
}
