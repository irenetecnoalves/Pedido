using System;
using System.Globalization;
using Pedido.Entities;
using Pedido.Entities.Enum;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Write Name: ");
            string clientName= Console.ReadLine(); // Escreve o nome do cliente e armazena numa variavel local criada 
            Console.Write("Write Email: ");
            string email = Console.ReadLine();
            Console.Write("write your birthday (DD/MM/YYYY):");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());//por que colocar orderSatus por ser uma lista de enuremaração 

            Client client = new Client(clientName,email,date);
            Order order = new Order(DateTime.Now,status,client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());// e a quantidade de produtos que o cliente digitar e criada uma variavel local

            for(int i=1; i<=n;i++)
            {
                Console.WriteLine($" Enter # {i} item data: ");
                Console.Write("Prodct Name: ");
                string nameProd = Console.ReadLine();
                Console.Write("Product Price: ");
                double price= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Prod prod = new Prod(nameProd,price);
                Console.Write("Quantity: ");
                int quanty = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem (quanty,price,prod);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order);

        }
    }
}
