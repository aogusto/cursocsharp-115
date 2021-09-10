using System;
using _115.Entities;
using _115.Entities.Enums;

namespace _115
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.Processing.ToString();
            OrderStatus txt2 = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine(txt);
            Console.WriteLine(txt2);

        }
    }
}
