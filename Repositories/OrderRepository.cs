using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository

    {

        public void DeleteOrder(Order p) => OrderDAO.DeleteOrder(p);
        public void SaveOrder(Order p) => OrderDAO.SaveOrder(p);
        public void UpdateOrder(Order p) => OrderDAO.UpdateOrder(p);
        public List<Order> GetOrders() => OrderDAO.GetOrders();

        public Order GetOrderById(int id) => OrderDAO.FindOrderById(id);
    }
}
