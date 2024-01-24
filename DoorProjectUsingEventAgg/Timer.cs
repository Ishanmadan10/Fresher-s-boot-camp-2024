using System;
namespace DoorProject{
public class Timer
{
    private readonly System.Timers.Timer _timer;
    private readonly IEventAggregator _eventAggregator;

    public Timer(int interval)
    {
        _timer = new System.Timers.Timer(interval);
        _eventAggregator = new EventAggregator();
    }

    public void Start()
    {
        _timer.Elapsed += TimerElapsed;
        _timer.Start();
    }

    private void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        _eventAggregator.Publish(new TimerElapsedEvent());
    }
}
}
