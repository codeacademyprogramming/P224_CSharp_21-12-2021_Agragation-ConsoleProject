using System;
using RestaurantManagement.Enums;
using RestaurantManagement.Models;

namespace RestaurantManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem menuItem1 = new MenuItem("Merci", 2.5, Category.Soup);
            MenuItem menuItem2 = new MenuItem("Tort", 7.5, Category.Desert);
            MenuItem menuItem3 = new MenuItem("Cola", 5.5, Category.Drink);
            MenuItem menuItem4 = new MenuItem("Kabab", 10, Category.Main);

            OrderItem orderItem1 = new OrderItem(menuItem1, 1);
            OrderItem orderItem2 = new OrderItem(menuItem2, 1);
            OrderItem orderItem3 = new OrderItem(menuItem3, 2);
            OrderItem orderItem4 = new OrderItem(menuItem4, 5);

            OrderItem[] orderItems = { orderItem1, orderItem2, orderItem3, orderItem4 };

            Order order = new Order(orderItems, "");

            Console.WriteLine(order);
        }
    }
}
