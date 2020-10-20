using System;
using System.Collections.Generic;

namespace Checkout
{
    public class Till
    {
        //Defined and declared a Dictionary of items
        private readonly Dictionary<char, int> _items = new Dictionary<char, int>{
            {'A', 0},
            {'B', 0},
            {'C', 0},
            {'D', 0}
        };

        //Defined and declared contants for prices and discounts of items
        private const double priceA = 50;
        private const double priceB = 30;
        private const double priceC = 20;
        private const double priceD = 15;
        private const double discountA = 20; //3 for 130 special
        private const double discountB = 15; //2 for 45 special

        //A public function to return total of prices for all items 
        public double Total()
        {
            double total = 0;
            foreach (var item in _items)
            {
                total += AddPriceItem(item);
                total -= AddDiscount(item);
            }
            return total;
        }

        // A private member to add the price by how many of the items checked
        private static double AddPriceItem(KeyValuePair<char, int> item)
        {

            double total = 0;
            switch (item.Key)
            {
                case 'A':
                    total = priceA * item.Value;
                    break;
                case 'B':
                    total = priceB * item.Value;
                    break;
                case 'C':
                    total = priceC * item.Value;
                    break;
                case 'D':
                    total = priceD * item.Value;
                    break;
            }
            return total;
        }

        //A private member to add discount for special items
        private static double AddDiscount(KeyValuePair<char, int> item)
        {
            double total = 0;
            int numberOfSpecialItems;
            switch (item.Key)
            {
                // A has special for "Buy 3 items for $130"
                case 'A':
                    numberOfSpecialItems = item.Value / 3;
                    total = numberOfSpecialItems * discountA;
                    break;
                // B has special for "Buy 2 items for $45"
                case 'B':
                    numberOfSpecialItems = item.Value / 2;
                    total = numberOfSpecialItems * discountB;
                    break;
            }
            return total;
        }

        //A public function to scan the items
        public void Scan(string items)
        {
            items = items.ToUpper(); //Not case sensitive; so convert all cases to uppercases
            //Add items
            foreach (var item in items)
            {
                _items[item]++;
                //Remove the last C item when the it is more than 6
                if (_items['C'] > 6)
                {
                    _items['C']--;
                }
            }


        }
    }
}