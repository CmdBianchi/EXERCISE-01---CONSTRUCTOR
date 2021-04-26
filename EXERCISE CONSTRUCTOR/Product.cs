using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace EXERCISE_CONSTRUCTOR{
    //----------------------START | OBJ PRODUCT------------------------//
    class Product {
        public string Name;
        public double Price;
        public double Amount;
    //------------------------ MET. CLASS -------------------------------//
        public double TotalValueStock() {
            return Price * Amount;
        }
        public void AddProduct(int amount) {
            Amount += amount;
        }
        public void RemoveProduct(int amount) {
            Amount -= amount;
        }

        public override string ToString() {
            return Name
            + "| $ " + Price.ToString("F2") +"| " + Amount + "  Unidades | Total: $ " + TotalValueStock().ToString("F2");
        }

    }
    //--------------------------- END --------------------------------//  
}
