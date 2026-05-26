using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeLibrary;

internal class Class3
{
    public static List<List<int>> Find(int[] numbers)
    {
        var results = new List<List<int>>();

        for (int i = 0; i < numbers.Length - 2; i++)
        {
            var left = i + 1;
            var right = numbers.Length - 1;

            while (left < right)
            {
                var sum = numbers[i] + numbers[left] + numbers[right];

                if (sum == 0)
                {
                    results.Add(new List<int>([numbers[i], numbers[left], numbers[right]]));
                    left++;
                    right--;

                    while (left < right && numbers[left] == numbers[left - 1])
                    {
                        left++;
                    }

                    while (left < right && numbers[right] == numbers[right + 1])
                    {
                        right--;
                    }
                }
                else if (sum < 0)
                    left++;
                else
                    right--;

            }
        }

        return results;
    }
}
