using RestaurantManagement.Enums;
using RestaurantManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Interfaces
{
    interface IRestaurantManager
    {
        MenuItem[] MenuItems { get; }
        Order[] Orders { get; }

        void AddOrder(OrderItem[] orderItems);
        void RemoveOrder(int orderNo);
        Order[] GetOrdersByDatesInterval(string startDate, string endDate);
        Order[] GetOrderByDate(string date);
        Order[] GetOrdersByPriceInterval(double startTotalAmount, double endTotalAmount);
        Order GetOrderByNo(int orderNo);
        void AddMenuItem(string name, double price, Category category);
        void EditMenuItem(string menuItemNo, string name, double price, Category category);
        MenuItem[] GetMenuItemsByCategory(Category category);
        MenuItem[] GetMenuItemsByPriceInterval(double startPrice, double endPrice);
        MenuItem[] SearchMenuItem(string search);
    }
}
