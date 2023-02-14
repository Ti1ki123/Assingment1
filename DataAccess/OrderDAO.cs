using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        public static List<Order> GetOrders()
        {

            var listOrders = new List<Order>();

            try
            {
                using (var context = new MyDbContext())
                {
                    listOrders = context.Orders.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return listOrders;
        }

        public static Order FindOrderById(int orderId)


        {

            Order p = new Order();

            try

            {
                using (var context = new MyDbContext())
                {

                    p = context.Orders.SingleOrDefault(x => x.OrderId == orderId);

                }

            }

            catch (Exception e)

            {
                throw new Exception(e.Message);

            }

            return p;
        }

        public static void SaveOrder(Order p)
        {

            try
            {
                using (var context = new MyDbContext())
                {
                    context.Orders.Add(p);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void UpdateOrder(Order p)

        {
            try
            {
                using (var context = new MyDbContext())
                {
                    context.Entry<Order>(p).State =
                    Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteOrder(Order p)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    var p1 = context.Orders.SingleOrDefault(
                    c => c.OrderId == p.OrderId);
                    context.Orders.Remove(p1);
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
