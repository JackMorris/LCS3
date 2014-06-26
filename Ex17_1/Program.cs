using System;

namespace Ex17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown countdown = new Countdown(10, "Hello, world!");

            CountdownDisplay countdownDisplay = new CountdownDisplay();
            countdownDisplay.Subscribe(countdown);

            countdown.Start();
        }
    }
}
