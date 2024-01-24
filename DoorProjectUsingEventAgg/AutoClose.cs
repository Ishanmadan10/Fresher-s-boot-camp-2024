using System;
namespace DoorProject{
public class AutoClose
{
    private readonly IEventAggregator _eventAggregator;

    public AutoClose(IEventAggregator eventAggregator)
    {
        _eventAggregator = eventAggregator;
        _eventAggregator.Subscribe<DoorAutoCloseEvent>(e => CloseDoorAutomatically());
    }

    public void CloseDoorAutomatically()
    {
        Console.WriteLine("Door closed automatically");
    }
}
}
