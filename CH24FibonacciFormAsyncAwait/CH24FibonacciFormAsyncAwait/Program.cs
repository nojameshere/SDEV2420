namespace CH24FibonacciFormAsyncAwait
{

    public class Program
    {
        private static long n1 = 0;
        private static long n2 = 1;
        private static long temp = 0;

        [STAThread]

        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public static long Iterative()
        {
            temp = n1 + n2;
            n1 = n2;
            n2 = temp;
            return n1;
        }
        public static long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        
    }
}