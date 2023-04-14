using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomise
{
    public class MainSubcriber
    {
        public int Priority { get; set; }

        public MainSubcriber(int priority)
        {
            Priority = priority;
        }
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine($"Priority {Priority} subscriber handling event");
        }
    }
}
