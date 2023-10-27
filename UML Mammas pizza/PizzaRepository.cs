using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Mammas_pizza
{
    class PizzaRepository
    {
        private Dictionary<string, Pizza> _pizzas;
        public PizzaRepository() { _pizzas = new Dictionary<string, Pizza>(); }

        public int Count {  get { return _pizzas.Count; } }

        public Pizza FindPizza(string id) {  return _pizzas[id]; }

        public bool AddPizza(Pizza piz)
        {
            return _pizzas.TryAdd(piz.Number, piz);
            //int check = _pizzas.Count;
            //_pizzas.Add(piz.Number, piz);
            //return check < _pizzas.Count; //if the count is bigger now, it means a pizza has been added to the dictionary
        }

        public bool DeletePizza(string id) { 
            return _pizzas.Remove(id);
        }

        public void UpdatePizza(string id, Pizza piz)
        {
            //if (!_pizzas.Remove(id))
            //    return false;
            //return _pizzas.TryAdd(piz.Number, piz);
            _pizzas[id] = piz;
            
        }

        public void PrintPiz()
        {
            foreach (var item in _pizzas)
            {
                Console.WriteLine(item.Value.ToString());
            }
        }

        public void Setup()
        {
            List<Topping> toppings1 = new List<Topping> { new Topping("Tomato", 0, true), new Topping("Cheese", 4, true), new Topping("Ham", 7, false), new Topping("Mushroom", 5, true) };
            List<Topping> toppings2 = new List<Topping> { new Topping("Tomato", 0, true), new Topping("Cheese", 4, true), new Topping("Mussels", 10, false), new Topping("Shrimp", 9, false), new Topping("Garlic", 4, true) };
            List<Topping> toppings3 = new List<Topping> { new Topping("Tomato", 0, true), new Topping("Cheese", 4, true), new Topping("Onion", 5, true), new Topping("Meat sauce", 10, false) };

            Pizza piz1 = new Pizza(toppings1, "3", "Capricossa", 8);
            Pizza piz2 = new Pizza(toppings2, "6", "Marinara", 85);
            Pizza piz3 = new Pizza(toppings3, "8", "Italiana", 75);

            _pizzas.Add(piz1.Number, piz1);
            _pizzas.Add(piz2.Number, piz2);
            _pizzas.Add(piz3.Number, piz3);
        }
    }
}
