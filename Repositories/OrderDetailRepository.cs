using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository

    {

        public void DeleteOrderDetail(OrderDetail p) => OrderDetailDAO.DeleteOrderDetail(p);
        public void SaveOrderDetail(OrderDetail p) => OrderDetailDAO.SaveOrderDetail(p);
        public void UpdateOrderDetail(OrderDetail p) => OrderDetailDAO.UpdateOrderDetail(p);
        public List<OrderDetail> GetOrderDetails() => OrderDetailDAO.GetOrderDetails();

        public OrderDetail GetOrderDetailById(int ordId, int prodId) => OrderDetailDAO.FindOrderDetailById(ordId, prodId);
    }
}
