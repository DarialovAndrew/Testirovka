using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testirovka
{
    public class Tasks
    {
        public List<T> Task1<T>(List<object> lst)
        {
            return lst.Where(x => x is T).Select<object, T>(x => { return (T)x; }).ToList();
        }
        public string Task2(string str)
        {
            return str.ToList().Where(x => str.Count(y => y.ToString().ToLower().Equals(x.ToString().ToLower())) == 1).FirstOrDefault().ToString();
        }
        public int Task3(int n)
        {
            string str = n.ToString();
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += int.Parse(str.Substring(i, 1));
            }
            str = sum.ToString();
            if (str.Length > 1)
            {
                sum = Task3(sum);
            }
            return sum;
        }
        public int Task4(int[] arr, int target)
        {
            int count = 0;
            var result = arr.Where(x => x <= target).ToList();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public string Task5(string str)
        {
            str = str.ToUpper();
            var result = str.Split(";").Select(x => {
                var result1 = x.Split(":");
                return new Tuple<string, string>(result1[1], result1[0]);
            }).OrderBy(x => x.Item1).ThenBy(x => x.Item2).Select(x => {
                return $"({x.Item1}, {x.Item2})";
            });
            return String.Join("", result);

        }
    }
}
