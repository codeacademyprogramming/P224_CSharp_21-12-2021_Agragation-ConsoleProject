using RestaurantManagement.Enums;
using RestaurantManagement.Interfaces;
using RestaurantManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagement.Services
{
    class RestaurantManager : IRestaurantManager
    {
        public MenuItem[] MenuItems => _menuItems;
        //{
        //    get
        //    {
        //        return _menuItems;
        //    }
        //}
        private MenuItem[] _menuItems;

        public Order[] Orders => _orders;
        private Order[] _orders;

        public void AddMenuItem(string name, double price, Category category)
        {
            throw new NotImplementedException();
        }

        public void AddOrder(OrderItem[] orderItems)
        {
            throw new NotImplementedException();
        }

        public void EditMenuItem(string menuItemNo, string name, double price, Category category)
        {
            throw new NotImplementedException();
        }

        public MenuItem[] GetMenuItemsByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public MenuItem[] GetMenuItemsByPriceInterval(double startPrice, double endPrice)
        {
            throw new NotImplementedException();
        }

        public Order[] GetOrderByDate(string date)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderByNo(int orderNo)
        {
            throw new NotImplementedException();
        }

        public Order[] GetOrdersByDatesInterval(string startDate, string endDate)
        {
            throw new NotImplementedException();
        }

        public Order[] GetOrdersByPriceInterval(double startTotalAmount, double endTotalAmount)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrder(int orderNo)
        {
            throw new NotImplementedException();
        }

        public MenuItem[] SearchMenuItem(string search)
        {
            throw new NotImplementedException();
        }
    }
}
