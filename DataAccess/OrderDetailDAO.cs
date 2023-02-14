using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        public static List<OrderDetail> GetOrderDetails()
        {

            var listOrderDetails = new List<OrderDetail>();

            try
            {
                using (var context = new MyDbContext())
                {
                    listOrderDetails = context.OrderDetails.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return listOrderDetails;
        }

        public static OrderDetail FindOrderDetailById(int ordId, int prodId)


        {

            OrderDetail p = new OrderDetail();

            try

            {
                using (var context = new MyDbContext())
                {

                    p = context.OrderDetails.SingleOrDefault(x => x.OrderId == ordId && x.ProductId == prodId);

                }

            }

            catch (Exception e)

            {
                throw new Exception(e.Message);

            }

            return p;
        }

        public static void SaveOrderDetail(OrderDetail p)
        {

            try
            {
                using (var context = new MyDbContext())
                {
                    context.OrderDetails.Add(p);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void UpdateOrderDetail(OrderDetail p)

        {
            try
            {
                using (var context = new MyDbContext())
                {
                    context.Entry<OrderDetail>(p).State =
                    Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteOrderDetail(OrderDetail p)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    var p1 = context.OrderDetails.SingleOrDefault(
                    c => c.OrderId == p.OrderId && c.ProductId == p.ProductId);
                    context.OrderDetails.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
