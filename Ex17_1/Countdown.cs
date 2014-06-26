using System;
using System.Threading;

namespace Ex17_1
{
    class Countdown
    {
        private uint timeInSeconds;
        private string message;

        public delegate void CountdownCompleteHandler(object countdown, CountdownInfoEventArgs countdownInfo);
        public CountdownCompleteHandler CountdownComplete;

        public Countdown(uint timeInSeconds, string message)
        {
            this.timeInSeconds = timeInSeconds;
            this.message = message;
        }

        public void Start()
        {
            Thread.Sleep((int)timeInSeconds * 1000);
            if (CountdownComplete != null)
            {
                CountdownComplete(this, new CountdownInfoEventArgs(timeInSeconds, message));
            }
        }
    }
}
