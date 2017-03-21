using System;
using SimpleEventAggregator.Events;

namespace SimpleEventAggregator
{
    public class OrderDetail :
        ISubscriber<OrderSelectedEvent>, ISubscriber<OrderSavedEvent>
    {
        public OrderDetail(IEventAggregator eventAggregator)
        {
            eventAggregator.Subscribe(this);
        }

        public void OnEvent(OrderSelectedEvent e)
        {
            Console.WriteLine(string.Format("Order Detail: {0}", e.Order.OrderNumber));
        }

        public void OnEvent(OrderSavedEvent e)
        {
            Console.WriteLine(string.Format("Order Saved: {0}", e.Order.OrderNumber));
        }
    }
}
