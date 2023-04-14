using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publication
{
    public class Publish
    {
        private Event eventBus;

        public Publish(Event eventBus)
        {
            this.eventBus = eventBus;
        }

        public void SendEvent()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    eventBus.Send("EvenEvent", this, EventArgs.Empty);
                }
                else
                {
                    eventBus.Send("OddEvent", this, EventArgs.Empty);
                }
                Thread.Sleep(2000);
            }
        }
    }

    public class PrioritySubscriber
    {
        public int Priority { get; set; }

        public PrioritySubscriber(int priority)
        {
            Priority = priority;
        }

        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine($"Priority {Priority} subscriber handling event");
        }
    }
}
