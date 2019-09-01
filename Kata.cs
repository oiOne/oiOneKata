using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace oiOneKata
{
    public class Kata
    {
        public static string AddBigNumbers(string a, string b)
        {
            return (long.Parse(a) + long.Parse(b)).ToString(); 
        }

        public static char FindMissingLetter(char[] array)
        {
            var output = char.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if((array[i+1]) != (array[i] + 1)) { 
                    output = (char)(array[i]+1);
                    break;
                }
            }

            return output;
        }

        public static int BouncingBall(double h, double bounce, double window)
        {
            if(h<=0 || bounce <=0 || bounce >= 1 || window >= h)
                return -1;

            var counter = 0;
            var last = h;
            while (last > window) {
                counter++;
                last *= bounce;
            }

            return (counter*2-1);
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var itr = iterable.ToArray();
            for (int i = 0; i < iterable.Count(); i++)
            {
                T uniq = itr[i];
                if(i + 1 < itr.Length)
                {
                    if(uniq.ToString().Equals(itr[i+1].ToString()))
                    {
                        continue;
                    }
                }
                yield return uniq;
            }
        }

        public static int Calculate(string num1, string num2)
        {
            var range = Enumerable.Range(0,128);
            var powRange = range.Select(x => (int)Math.Pow(2, x)).ToArray();


            int CalcNum(string num)
            {
                if(num.Length == 1)
                {
                    return (int)char.GetNumericValue(num.ToCharArray()[0]);
                }
                var output = 0;
                var reversed = (num1.Length == 1 ? "0"+num : num).Reverse().ToArray();
                for (int i = 0; i < reversed.Length; i++)
                {
                    var val = char.GetNumericValue(reversed[i]);
                    output += val == 1 ? powRange[i] : 0;
                }
                return output;
            }
            
            return CalcNum(num1) + CalcNum(num2);
        }

        public static int[] MoveZeroes(int[] arr)
        {
            //return arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
            var output = new int[arr.Length];
            var nilCounter = 0;
            var position = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    nilCounter++;
                }
                else
                {
                    position = position + 1;
                    output[position] = arr[i];
                }
            }
            for (int i = 0; i < nilCounter; i++)
            {
                position = position + 1;
                output[position] = 0;
            }
            return output;
        }
        public static long hamming(int n)
        {
            return (long)n;
  	        // TODO: Program me
        }
        public static bool ValidatePin(string pin)
        {
            return (pin.Length == 4 || pin.Length == 6) 
                && pin.All(x => char.IsDigit(x));
        }

    }

    
}
