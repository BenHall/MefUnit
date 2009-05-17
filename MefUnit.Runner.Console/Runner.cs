namespace MefUnit.Runner.Console
{
    public class Runner
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Executing Tests");

            while (true)
            {
                Framework f = new Framework();
                f.Refresh();
                f.RunMefs();
                System.Console.ReadLine();
            }
        }
    }
}