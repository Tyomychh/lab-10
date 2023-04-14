using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomise
{
    public class Publication
    {
        private Event eventBus;

        public Publication(Event eventBus)
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
}
