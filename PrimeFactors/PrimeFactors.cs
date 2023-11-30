namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static List<int> Generate(int number)
        {
            List<int> factors = [];

            int candidate = 2;

            while (number > 1)
            {
                while (number % candidate == 0)
                {
                    factors.Add(candidate);
                    number /= candidate;
                }

                candidate++;
            }

            return factors;
        }

        // first try code ( followed the guide)
        //public static List<int> Generate(int number)
        //{
        //    List<int> primes = [];

        //    for (int candidate = 2; number > 1; candidate++)
        //        for (; number % candidate == 0; number /= candidate)
        //            primes.Add(candidate);


        //    return primes;
        //}
    }
}
