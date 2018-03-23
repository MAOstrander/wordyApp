using System;

namespace wordyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f' };
            
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine(letters[i]);


                for (int j = 0; j < letters.Length; j++)
                {
                    if (j != i )
                    {
                        Console.WriteLine(letters[i].ToString() + letters[j].ToString());

                        for (int k = 0; k < letters.Length; k++)
                        {
                            if (k != i && k != j)
                            {
                                Console.WriteLine(letters[i].ToString() + letters[j].ToString() + letters[k].ToString());
                            }


                        }

                    }
                }
            }

            Console.WriteLine("End!");
        }

        public static void WriteOthers(char[] thing, int baseIndex)
        {
            string outputString = "";

            for (int i = 0 ; i < thing.Length; i++)
            {
                if (i != baseIndex)
                {
                   outputString += thing[i].ToString();
                }
            }
            Console.WriteLine(outputString);

        }

    }
}
