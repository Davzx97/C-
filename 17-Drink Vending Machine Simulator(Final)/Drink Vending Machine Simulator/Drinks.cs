using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink_Vending_Machine_Simulator
{
    class Drinks
    {
        //backing fields
        private string _name;
        private decimal _cost;
        private int _numberOfDrinks = 20;
        //Constructor
        public Drinks(string name, decimal cost)
        {
            this._name = name;
            this._cost = cost;
        }//end Constructor
        //Name Property
        public string Name
        {
            get {return this._name; }
            set { this._name = value; }
        }//end Property
        //Cost Property
        public decimal Cost
        {
            get { return this._cost; }
            set { this._cost = value; }
        }//end Property
        //NumberOfDrinks Property
        public int NumberOfDrinks
        {
            get { return this._numberOfDrinks; }
            set { this._numberOfDrinks = value; }
        }//end Property
    }//end class
}//end namespace
