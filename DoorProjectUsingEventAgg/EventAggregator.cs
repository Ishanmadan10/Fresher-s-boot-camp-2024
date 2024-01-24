
using System;
using System.Collections.Generic;
namespace DoorProject{
public interface IEventAggregator
{
    void Subscribe<TEvent>(Action<TEvent> action) where TEvent : EventBase;
    void Publish<TEvent>(TEvent @event) where TEvent : EventBase;
}

public class EventBase { }

public class EventAggregator : IEventAggregator
{
    private readonly Dictionary<Type, List<Delegate>> _eventHandlers = new Dictionary<Type, List<Delegate>>();

    public void Subscribe<TEvent>(Action<TEvent> action) where TEvent : EventBase
    {
        var eventType = typeof(TEvent);

        if (!_eventHandlers.ContainsKey(eventType))
        {
            _eventHandlers[eventType] = new List<Delegate>();
        }

        _eventHandlers[eventType].Add(action);
    }

    public void Publish<TEvent>(TEvent @event) where TEvent : EventBase
    {
        var eventType = typeof(TEvent);

        if (_eventHandlers.ContainsKey(eventType))
        {
            foreach (var handler in _eventHandlers[eventType])
            {
                ((Action<TEvent>)handler)?.Invoke(@event);
            }
        }
    }
}
}
