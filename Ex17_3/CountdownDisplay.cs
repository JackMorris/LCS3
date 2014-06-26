using System;

namespace Ex17_3
{
    class CountdownDisplay
    {
        public void Subscribe(Countdown countdown)
        {
            countdown.CountdownComplete += delegate(object c, CountdownInfoEventArgs countdownInfo)
            {
                var timeInSeconds = countdownInfo.TimeInSeconds;
                var message = countdownInfo.Message;
                System.Console.WriteLine("Countdown completed in {0} seconds: '{1}'", timeInSeconds, message);
            };
        }
    }
}
