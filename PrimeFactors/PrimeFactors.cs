namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static List<int> Generate(int number)
        {
            List<int> factors = [];

            if (number > 1)
            {
                if (number%2 == 0)
                {
                    factors.Add(2);
                    number /= 2;
                }
                    
                if (number > 1)
                    factors.Add(number);
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
