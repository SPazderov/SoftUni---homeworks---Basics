using System;

namespace Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string character = Console.ReadLine();

            for (int i = 0; i < character.Length; i++)
            {
                Console.WriteLine(character[i]);
            }
        }
    }
}
