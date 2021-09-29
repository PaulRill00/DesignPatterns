namespace State
{
    internal class Program
    {
        private static void Main()
        {
            var context = new Context();

            for (var i = 0; i < 5; i++)
            {
                context.Handle();
            }
        }
    }
}
