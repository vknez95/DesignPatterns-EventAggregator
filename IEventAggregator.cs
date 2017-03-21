using System;
using System.Collections.Generic;

namespace SimpleEventAggregator
{
    public interface IEventAggregator
    {
        void Subscribe(object subscriber);
        void Publish<TEvent>(TEvent eventToPublish);
        bool Contains(Type eventType);
    }
}
