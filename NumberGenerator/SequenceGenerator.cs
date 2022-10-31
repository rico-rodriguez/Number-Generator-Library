namespace popQuiz
{
    public class SequenceGenerator : INumberSequenceGenerator
    {
        public static List<int> GenerateSequence(int start, int end)
        {
            List<int> listOfNumbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                listOfNumbers.Add(i);
            }
            return listOfNumbers;
        }

        public List<int> GetSequence(int end, int start = 0)
        {
            return GenerateSequence(start, end);
        }
    }
}
