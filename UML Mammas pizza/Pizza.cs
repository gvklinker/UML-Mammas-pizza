using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Mammas_pizza
{
    class Pizza
    {
        private List<Topping> _toppings = new List<Topping>();
        private List<Topping> _extras = new List<Topping>();
        private string _num;
        private string _name;
        private int _price;

        public Pizza(List<Topping> top, string num, string name, int price) {
            _toppings.AddRange(top);
            _num = num;
            _name = name;
            _price = price;
        }

        public string Number { get { return _num; } }
        public string Name { get { return _name; } }
        public int Price { get { return _price; } }
        public bool IsVeggie { get { 
                foreach (Topping top in _toppings) {
                    if(!top.IsVeggie)
                        return false;}
                    return true;
                } 
        }

        public override string ToString()
        {
            string s = $"{_num} {_name} {_price} \n {string.Join(" ", _toppings)}";
            if(_extras.Count > 0) { s += $"\n Extras: {string.Join(" ", _extras)}"; }
            return s;
        }

        public void AddTopping(Topping topping)
        {
            _extras.Add(topping);
        }

        public void RemoveTopping(Topping topping) {  
           if(!_extras.Remove(topping))
                _toppings.Remove(topping);
        }


    }
}
