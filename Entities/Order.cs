using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Pedido.Entities.Enum;

namespace Pedido.Entities
{
    public class Order
    {
       public DateTime Moment { get; set; }
       public OrderStatus Status { get; set; }
       public Client Client { get; set; }

       public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(){}

    public Order(DateTime moment,OrderStatus status,Client client)
    {
        Moment =moment;
        Status = status;
        Client = client;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        Items.Remove(item);
    }
   
   public double Total()
   {
       double sum = 0.0;
      foreach(OrderItem item in Items)
      { sum += item.Total();
      }
      return sum;

    }

    public override string ToString()
    {
        
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Order Moment: "+Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.AppendLine("Order Status :" + Status);
        sb.AppendLine("Cliente: "+Client);
        Console.WriteLine();
        sb.AppendLine("Order Itens: ");        
        foreach(OrderItem item in Items)
        {
            sb.AppendLine(item.ToString());
        }
        sb.AppendLine("Total Price:R$ "+Total().ToString("F2",CultureInfo.InvariantCulture));
        return sb.ToString();
    }


}
} 