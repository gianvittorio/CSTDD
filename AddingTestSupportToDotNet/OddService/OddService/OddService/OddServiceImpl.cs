namespace OddService
{
    public class OddServiceImpl
    {
        public bool IsOdd(int number)
        {
            return (number % 2 != 0);
        }
    }
}