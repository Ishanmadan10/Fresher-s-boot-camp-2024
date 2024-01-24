using System;
namespace DoorProject{
public class Buzzer
{
    private readonly IEventAggregator _eventAggregator;

    public Buzzer(IEventAggregator eventAggregator)
    {
        _eventAggregator = eventAggregator;
        _eventAggregator.Subscribe<DoorAutoCloseEvent>(e => ActivateBuzzer());
    }

    public void ActivateBuzzer()
    {
        Console.WriteLine("Buzzer activated!");
    }
}
}
