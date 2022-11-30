using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_LINQ
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public override string ToString() => $"ID={ID},Name={Name},Value={Value}";

    }
}
