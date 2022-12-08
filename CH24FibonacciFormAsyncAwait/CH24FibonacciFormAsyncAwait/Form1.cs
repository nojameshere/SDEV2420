namespace CH24FibonacciFormAsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async private void RecursiveButton_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            calcResultLabel.Text = "Calculating...";
            //Call recursive method
            Task<long> fibonacciTask = Task.Factory.StartNew(() => Program.Fibonacci(long.Parse(fibonacciNumbers.Text)));
            await fibonacciTask;
            calcResultLabel.Text = fibonacciTask.Result.ToString();
            DateTime endTime = DateTime.Now;
            double seconds = (endTime - startTime).TotalSeconds;
            //Display the seconds in the label
            timeTaken.Text = seconds.ToString();
        }

        private void IterativeButton_Click(object sender, EventArgs e)
        {
            IterativeResult.Text = Program.Iterative().ToString();
        }
    }
}