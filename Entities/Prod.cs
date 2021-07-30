using System;


namespace Pedido.Entities
{
    public class Prod
    {
        public string Name { get; set; }
        public double Price { get; set; }

         public Prod()
          {}
    public Prod (string name,double price)
    {
        Name= name;
        Price = price;
    }
    }
   
}