using System;

namespace Ex17_4
{
    class CountdownDisplay
    {
        public void Subscribe(Countdown countdown)
        {
            countdown.CountdownComplete += (c, countdownInfo) =>
                {
                    var timeInSeconds = countdownInfo.TimeInSeconds;
                    var message = countdownInfo.Message;
                    System.Console.WriteLine("Countdown completed in {0} seconds: '{1}'", timeInSeconds, message);
                };
        }
    }
}
