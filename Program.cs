using System;

namespace CSC_205_EX7_10
{
    public class AbecedarianChecker
    {
        public static bool IsAbecedarian(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] > word[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Main(string[] args)
        {
            // Test cases
            Console.WriteLine(IsAbecedarian("abdest")); // True
            Console.WriteLine(IsAbecedarian("agnosy")); // True
            Console.WriteLine(IsAbecedarian("biopsy")); // True
            Console.WriteLine(IsAbecedarian("deux"));   // True
            Console.WriteLine(IsAbecedarian("dimpsy")); // True
            Console.WriteLine(IsAbecedarian("hello"));  // False

            Console.ReadKey();
        }
    }
}
