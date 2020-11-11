using System;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    a = a + 1;
                }
            }
            int[] vysledok = new int[a];
            for (int ii = 0; ii < numbers.Length; ii++)
            {
                if (numbers[ii] % 2 == 0)
                {
                    vysledok[b] = numbers[ii];
                    b = b + 1;
                }
            }
            return vysledok;
        }
    }
}
