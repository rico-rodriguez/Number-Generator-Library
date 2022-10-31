namespace popQuiz
{
    public class RandomSequenceGenerator : INumberSequenceGenerator
    {
        public List<int> GetSequence(int end, int start = 0)
        {
            return RandomNumberSequence(end);
        }

        public List<int> RandomNumberSequence(int length, int start = 0)
        {
            List<int> listOfNumbers = new List<int>();
            Random r = new Random();

            for (int i = 0; i <= length; i++)
            {
                listOfNumbers.Add(r.Next(1, 1000));
            }
            return listOfNumbers;



        }
    }
}
