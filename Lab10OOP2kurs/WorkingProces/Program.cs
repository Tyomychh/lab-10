namespace WorkingProces
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Workflow started");
            Console.WriteLine();

            var workflow = new Flow();
            workflow.ActionAdded += OnActionAdded;
            workflow.ActionCompleted += OnActionCompleted;
            workflow.WorkflowCompleted += OnWorkflowCompleted;

            workflow.Run();

            Console.WriteLine("Workflow ended");
        }

        private static void OnActionAdded(object sender, ActionEventArgs a)
        {
            Console.WriteLine($"Action '{a.Action.Name}' added to the workflow");
            Console.WriteLine();
        }

        private static void OnActionCompleted(object sender, ActionEventArgs a)
        {
            Console.WriteLine($"Action '{a.Action.Name}' completed");
            Console.WriteLine();
        }

        private static void OnWorkflowCompleted(object sender, EventArgs a)
        {
            Console.WriteLine("Workflow completed");
            Console.WriteLine();
        }
    }
}