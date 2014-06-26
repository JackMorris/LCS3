using System;

namespace Ex17_2
{
    class CountdownInfoEventArgs : EventArgs
    {
        public uint TimeInSeconds;
        public string Message;

        public CountdownInfoEventArgs(uint timeInSeconds, string message)
        {
            this.TimeInSeconds = timeInSeconds;
            this.Message = message;
        }
    }
}
