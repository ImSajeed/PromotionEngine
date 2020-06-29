using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        protected readonly Dictionary<string,int> priceMap = new Dictionary<string,int>{{"A",50},{"B",30},{"C",20},{"D",15}};
        static void Main(string[] args)
        {
            List<string> cart = new List<string>();
            cart.Add("A");
            cart.Add("A");
            cart.Add("A");
            cart.Add("B");
            cart.Add("B");
            cart.Add("B");
            cart.Add("B");
            cart.Add("B");
            cart.Add("C");
            cart.Add("D");

            
        }
    }
}
