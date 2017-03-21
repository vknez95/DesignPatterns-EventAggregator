using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleEventAggregator.Events;

namespace SimpleEventAggregator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Order order = new Order() { OrderNumber = "1", Description = "First order description" };

            IEventAggregator eventAggregator = new SimpleEventAggregator();

            OrderSavedEvent saveEvent = new OrderSavedEvent() { Order = order };

            OrderDetail orderDetail = new OrderDetail(eventAggregator);

            if (!eventAggregator.Contains(saveEvent.GetType()))
                Console.WriteLine(string.Format("No subscribers of event type {0} subscribed.", saveEvent.GetType().Name));

            eventAggregator.Publish(saveEvent);
        }
    }
}
