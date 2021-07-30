
using System.Globalization;
namespace Pedido.Entities
{
    public class OrderItem
    {
        public int Quanty { get; set; }
        public double Price { get; set; }
        public Prod Prods { get; set; }

        public OrderItem(){}

        public OrderItem(int quanty, double price, Prod prods)
        {
            Quanty = quanty;
            Price = price;
            Prods = prods;
        }

        public double Total()
        {
            return Quanty * Price;
        }

        public override string ToString()
        { 
          
            return Prods.Name + ",R$ " 
            + Price.ToString("F2",CultureInfo.InvariantCulture)
            + ",Quantity:" + Quanty
            + ",Subtotal:R$ "
            + Total().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}