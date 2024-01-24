using System;
namespace DoorProject{
public class DoorOpenedEvent : EventBase { }
public class DoorClosedEvent : EventBase { }

public class SimpleDoor
{
    private readonly IEventAggregator _eventAggregator;

    public SimpleDoor(IEventAggregator eventAggregator)
    {
        _eventAggregator = eventAggregator;
    }

    public void Open()
    {
        Console.WriteLine("Simple door opened");
        _eventAggregator.Publish(new DoorOpenedEvent());
    }

    public void Close()
    {
        Console.WriteLine("Simple door closed");
        _eventAggregator.Publish(new DoorClosedEvent());
    }
}
}
