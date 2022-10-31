namespace popQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbers(1, 2);

            INumberSequenceGenerator sg = new SequenceGenerator();

            AddAndPrintSequence(sg.GetSequence(5, 1));

            INumberSequenceGenerator rg = new RandomSequenceGenerator();

            AddAndPrintSequence(rg.GetSequence(5, 1));

        }


        private static int AddTwoNumbers(int a, int b) => a + b;

        private static void AddAndPrintSequence(List<int> numbers)
        {
            numbers.Sort((a, b) => b.CompareTo(a));
            var prev = 0;
            var next = 0;
            foreach (int number in numbers)
            {
                prev = number;
                Console.WriteLine($"N1: {prev} N2: {next} Sum: {AddTwoNumbers(prev, next)}");
                next = prev;
            }
        }
    }
}