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
            _pizzas[piz.Number] = piz;
            
        }
    }
}
