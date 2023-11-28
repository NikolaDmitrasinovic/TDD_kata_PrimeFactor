
namespace PrimeFactor
{
    public class PrimeFactors
    {
        public static List<int> Generate(int number)
        {
            List<int> primes = [];

            if (number > 1)
            {
                primes.Add(2);
            }

            return primes;
        }
    }
}
