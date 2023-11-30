﻿namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static List<int> Generate(int number)
        {
            if (number < 2)
                return [];
            else if (number == 2)
                return [2];

            return [3];
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
