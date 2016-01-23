using System;
using System.Threading;

namespace _03.AsynchronousTimer
{
    class AsyncTimer
    {
        private int interval;
        private int ticks;

        public AsyncTimer(Action<int> action, int ticks, int interval)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.Interval = interval;
        }

        public Action<int> Action { get; private set; }
        public int Interval
        {
            get { return this.interval; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interval cannot be negative!");
                }

                this.interval = value;
            }
        }
        public int Ticks
        {
            get { return this.ticks; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ticks cannot be negative!");
                }

                this.ticks = value;
            }
        }
        public void Execute()
        {
            Thread thread = new Thread(this.Run);
            thread.Start();
        }
        public void Run()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.Interval);
                if (this.Action != null)
                {
                    this.Action(i);
                }
            }
        }
    }
}
