namespace EventBUs
{

    public class Program
    {
        static void Main()
        {

            EventThrottler eventBus = new EventThrottler();

            EventHandler handler1 = (sender, e) =>
            {
                Console.WriteLine($"Handler 1 triggered at {DateTime.Now}");
            };

            EventHandler handler2 = (sender, e) =>
            {
                Console.WriteLine($"Handler 2 triggered at {DateTime.Now}");
            };

            eventBus.RegisterEventHandler("event1", handler1);
            eventBus.RegisterEventHandler("event1", handler2);

            for (int i = 0; i < 10; i++)
            {
                eventBus.TriggerEvent("event1", EventArgs.Empty, 1000);
                Thread.Sleep(500);
            }

            eventBus.UnregisterEventHandler("event1", handler2);

            for (int i = 0; i < 10; i++)
            {
                eventBus.TriggerEvent("event1", EventArgs.Empty, 2000);
                Thread.Sleep(500);
            }

        }
    }
}