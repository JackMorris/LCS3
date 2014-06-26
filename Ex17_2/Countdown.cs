using System;
using System.Threading;

namespace Ex17_2
{
    class Countdown
    {
        private uint timeInSeconds;
        private string message;

        public delegate void CountdownCompleteHandler(object countdown, CountdownInfoEventArgs countdownInfo);
        public event CountdownCompleteHandler CountdownComplete;
        // Marking the above as an 'event' (which should be done in Ex17_1 anyway) was what I assumed to be 
        // the intended modification.

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
