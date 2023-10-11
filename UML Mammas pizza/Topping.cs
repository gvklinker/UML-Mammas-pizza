using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Mammas_pizza
{
    class Topping
    {
        public string Name { get; set; }
        public int Price {  get; set; }
        public bool IsVeggie {  get; set; }

        public Topping(string name, int price, bool veggie) {
            Name = name;
            Price = price;
            IsVeggie = veggie;
        }

        public string FullToString()
        {
            return $"Name :{Name}, Price {Price} kr, Vegitarian: {IsVeggie}";
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
