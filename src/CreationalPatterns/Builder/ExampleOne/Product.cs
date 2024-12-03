using System.Collections.Generic;
using System.Diagnostics;

namespace src.CreationalPatterns.Builder.ExampleOne
{
    /*
     * It makes sense to use the Bulder pattern only whenn your proudcts are quite complex and require extensive configuarion
     * 
     * Unlike in other creational patterns, different concrete vuilders can produce unrelated products. In other words, results
     * of varios builders may not always follow the same interface
     */
    public class Product
    {
        private List<object> _parts = [];

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i =0; i< this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "/n";
        }
    }
}
