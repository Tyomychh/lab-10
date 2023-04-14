namespace Randomise
{
    public class Program
    {
        static void Main()
        {
            Event eventBus = new Event(5, 1000, 5000, 1.5);
            Publication publisher = new Publication(eventBus);

            MainSubcriber sub1 = new MainSubcriber(1);
            MainSubcriber sub2 = new MainSubcriber(2);
            MainSubcriber sub3 = new MainSubcriber(3);

            eventBus.Register("OddEvent", sub1.Priority, new Action<object, EventArgs>(sub1.HandleEvent));
            eventBus.Register("EvenEvent", sub2.Priority, new Action<object, EventArgs>(sub2.HandleEvent));
            eventBus.Register("OddEvent", sub3.Priority, new Action<object, EventArgs>(sub3.HandleEvent));


            publisher.SendEvent();

            Console.ReadLine();
        }
    }
}