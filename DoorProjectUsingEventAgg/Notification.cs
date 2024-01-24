using System;
namespace DoorProject{
public class Notifier
{
    private readonly IEventAggregator _eventAggregator;

    public Notifier(IEventAggregator eventAggregator)
    {
        _eventAggregator = eventAggregator;
        _eventAggregator.Subscribe<DoorAutoCloseEvent>(e => SendNotification());
    }

    public void SendNotification()
    {
        Console.WriteLine("Notification sent!");
    }
}
}
