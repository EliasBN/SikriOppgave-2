using System;

namespace SikriOppgave
{
    

// The main class for performing operations on a List. 
    class ListeService
    {

        // Checks if a value is an EvenNumber. 
        public ListeService isEvenNumber(int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine("{0} is an even number!", value);
            }
            return this;
        }

        // Prints out a line if a number(int value) is divisible by 7. 
        public ListeService printSeven(int value) 
        {

            if (value % 7 == 0 && value != 0)
            {
                Console.WriteLine("{0} is divisble by 7.", value);
            }
            return this;
        }

        /// Simple implementation of the popular math game FizzBuzz. Prints out 
        /// Fizz if a value is divisible by 5, Buzz if divisible by 3, and fizzbuzz if 
        /// divisible by both. 
        public ListeService fizzBuzz(int value)
        {

            if (value % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (value % 5 == 0)
            {
                Console.WriteLine("Fizz!");
            }
            else if (value % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            return this;
        }
    }
}
