using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Model = Models;
using Entity = DL.Entities;
using System.Linq;
using Models;

//Still need to fix the Orders, and StorFront Repositories

namespace DL
{
    public class OrdersRepository : IOrdersRepository
    {
        private Entities.DemoDBContext _context;

        public OrdersRepository(Entities.DemoDBContext p_context)
        {
            _context = p_context;
        }
        public bool AddOrder(Entity.Order p_order)
        {
            _context.Orders.Add(new Entity.Order{
                Order_Id = p_order.Order_Id,
                OrderLineItems = p_order.OrderLineItems,
                TotalPrice = p_order.TotalPrice, 
            });
            _context.SaveChanges();
            return true;
        }
        public List<Models.Orders> GetAllOrders()
        {
            return _context.Orders.Select(
                orders =>
                    new Models.Orders()
                    {
                        OrderLinetItems = orders.OrderLineItems,
                        Total_Price = (int)orders.TotalPrice,
                    }
            ).ToList();
        }

        public Models.Orders GetOrder(int p_order_Id)
        {
            var output =  _context.Orders.Find(p_order_Id);

            return              
                new Models.Orders()
                {
                    // OrderLineItems = output.OrderLineItems,
                    // Total_Price = (int)output.TotalPrice,

                    
                }
        }

        public List<Orders> GetOrders()
        {
            throw new NotImplementedException();
        }
    }

        public List<Models.Orders> GetOrders()
        {
            throw new NotImplementedException();
        }
    }
}   