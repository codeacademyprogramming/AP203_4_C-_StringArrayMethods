using System;

namespace _14032022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //String methods
            #region String methods  

            //string str = "Hello  World  P203 ";

            //Console.WriteLine(str);
            //Console.WriteLine(str.Trim());
            //Console.WriteLine(str);

            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.StartsWith("   h"));
            //Console.WriteLine(str.EndsWith("d   "));
            //Console.WriteLine(str.IndexOf('l'));
            //Console.WriteLine(str.LastIndexOf('l'));
            //Console.WriteLine("Axtaris deyerini daxil edin:");
            //string search = " ";
            //Console.WriteLine(str.ToUpper().Contains(search.ToUpper()));

            //Console.WriteLine(str.Replace("Hello", "Goodby"));

            //Console.WriteLine(str.Substring(str.LastIndexOf('H'),3));

            //var result = str.Split(" ");
            //Console.WriteLine(result.Length);
            #endregion


            //Array methods
            #region Array methods

            //int[] nums = { 1, 44, 3, 1, 5, 16, };

            //int[] newNums = new int[nums.Length];

            //nums.CopyTo(newNums, 0);

            //foreach (var item in newNums)
            //{
            //    Console.WriteLine(item);
            //}

            //var wantedIndex = Array.IndexOf(nums, 3);
            //Array.Clear(nums, 2, 3);
            //Console.WriteLine(wantedIndex);

            //Array.Resize(ref nums,nums.Length+1);
            //nums[nums.Length - 1] = 10;

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(nums);
            //Array.Reverse(nums);


            //Console.WriteLine("numbres: ") ;
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] letters = { "A", "B", "C", "D" };

            //string str = String.Join('-', letters);

            //Console.WriteLine(str);
            #endregion


            #region CharMethods

            Console.WriteLine(char.IsLetter('5'));
            #endregion

            int num;
            string numStr;

            do
            {
                Console.WriteLine("Eded daxil et:");
                numStr = Console.ReadLine();

            } while (!int.TryParse(numStr, out num));

            Console.WriteLine(num);


            Console.WriteLine(FindFirstWord("   Hello   World  "));
        }

        static string FindFirstWord(string str)
        {
            str = str.Trim();

            //return str.Substring(0, str.IndexOf(' '));
            return str.Split(' ')[0];
        }

        
    }
}
