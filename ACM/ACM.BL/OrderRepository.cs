using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        // Retrieve one Order
        public Order Retrieve(int orderId)
        {
            // Create the instance of order class
            // Pass in the requested id
            Order order = new Order(orderId);

            // Code that retrieves defined order

            // Temporary hard coded values to return 
            // a populated customer
            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                     new TimeSpan(7, 0, 0));
            }
            return order;
        }

        // Save the current customer
        public bool Save(Order order)
        {
            // Code that saves passed in customer

            return true;
        }
    }
}
