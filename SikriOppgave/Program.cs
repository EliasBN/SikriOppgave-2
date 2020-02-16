using System.Collections;

namespace SikriOppgave
{
    class Program
    {
        static void Main(string[] args)
        {
            ListeService listeService = new ListeService();
            ArrayList a = populateArray(100);

            // Kunne muligens ha vært en egen metode. 
            foreach (int e in a)
            {
                listeService
                    .printSeven(e)
                    .fizzBuzz(e)
                    .isEvenNumber(e);
            }
        }


        private static ArrayList populateArray(int length)
        {
            ArrayList a = new ArrayList();

            for (int counter = 0; counter <= length; counter++)
            {
                a.Add(counter);
            }
            return a;
        }
    }
}



