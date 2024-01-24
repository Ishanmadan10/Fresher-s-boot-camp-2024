using System;
namespace DoorProject{
public class TimerElapsedEvent : EventBase { }
public class DoorAutoCloseEvent : EventBase { }

public class SmartDoor : SimpleDoor
{
    private readonly IEventAggregator _eventAggregator;
    private readonly System.Timers.Timer _timer;
    private bool _isDoorOpen;

    public SmartDoor(IEventAggregator eventAggregator, int maxOpenTime) : base(eventAggregator)
    {
        _eventAggregator = eventAggregator;
        _isDoorOpen = false;

        _timer = new System.Timers.Timer(maxOpenTime);
        _timer.Elapsed += TimerElapsed;

        _eventAggregator.Subscribe<DoorOpenedEvent>(e => _isDoorOpen = true);
        _eventAggregator.Subscribe<DoorClosedEvent>(e => _isDoorOpen = false);
    }

    public void ActivateSmartFeatures(bool useBuzzer, bool useNotifier, bool autoClose)
    {
        _timer.Start();

        if (autoClose)
        {
            _eventAggregator.Subscribe<DoorAutoCloseEvent>(e => CloseDoor());
        }

        if (useBuzzer)
        {
            _eventAggregator.Subscribe<DoorAutoCloseEvent>(e => ActivateBuzzer());
        }

        if (useNotifier)
        {
            _eventAggregator.Subscribe<DoorAutoCloseEvent>(e => SendNotification());
        }
    }

    private void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        if (_isDoorOpen)
        {
            Console.WriteLine("Door open for too long! Activating auto-close...");
            CloseDoor();
            _eventAggregator.Publish(new DoorAutoCloseEvent());
        }
    }

    private void ActivateBuzzer()
    {
        Console.WriteLine("Buzzer activated!");
    }

    private void SendNotification()
    {
        Console.WriteLine("Notification sent!");
    }

    private void CloseDoor()
    {
        Console.WriteLine("Door closed automatically");
        Close();
    }
}
}
