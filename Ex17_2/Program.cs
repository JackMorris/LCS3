using System;

namespace Ex17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown countdown = new Countdown(10, "Hello, world!");

            CountdownDisplay countdownDisplay = new CountdownDisplay();
            countdownDisplay.Subscribe(countdown);
            CountdownDisplay countdownDisplay2 = new CountdownDisplay();
            countdownDisplay2.Subscribe(countdown);

            countdown.Start();
        }
    }
}
