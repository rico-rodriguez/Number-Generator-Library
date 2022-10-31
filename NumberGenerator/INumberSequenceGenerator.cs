namespace popQuiz
{
    public interface INumberSequenceGenerator
    {
        List<int> GetSequence(int end, int start = 0);
    }
}
