using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace AlgorithmProblem
{
    public static class Algorithms
    {
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void InsertionSort()
        {
            int[] arr = { 2, 4, 5, 1, 3, 6, 8, 7 };
            int temp, i, j;

            for (i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
        public static void anagramString(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Both string length are not equal");
            }
            else
            {
                char[] ch1 = str1.ToLower().ToCharArray();
                char[] ch2 = str2.ToLower().ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                string val1 = new string(ch1);
                string val2 = new string(ch2);
                if (val1 == val2)
                {
                    Console.WriteLine("is a anagram string");
                }
                else
                {
                    Console.WriteLine("is not anagram string");
                }
            }
        }

        public static void Palindrome(int temp)
        {
            int num = temp, sum = 0, rem = 0;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum * 10 + rem;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine(temp + " is a palindrome number");
            }

        }
        public static void PrintPrime(int limit)
        {
            int count = 0;
            for (int i = 2; i <= limit; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;

                    }
                }
                if (count == 2)
                {
                    Palindrome(i);
                }
                count = 0;
            }
        }


        public static int GuessNumber(int low, int high)
        {
            bool guessNum;
            int mid;
            while (low < high)
            {
                mid = (low + high) / 2;
                Console.WriteLine("Enter true if number bitween" + low + "-" + mid);
                Console.WriteLine("Enter false if number bitween" + (mid + 1) + "-" + high);
                guessNum = Convert.ToBoolean(Console.ReadLine());
                if (guessNum)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }

        //Custom String 
        public static bool isString(string str)
        {
            Regex pattern = new Regex("^[a-zA-Z ]*$");
            return ((!str.Equals("")) && (str != null) && (!pattern.IsMatch(str)));
        }
        public static bool isMobileNumber(string str)
        {
            Regex pattern = new Regex("\\d{10}");
            return pattern.IsMatch(str);
        }

        public static void CustomMessage()
        {
            string str = "Hello <<name>>, We have your fullname as <<fullname>> in our system."
                + " your contact number is 91-xxxxxxxxxx.\n"
                + "Please,let us know in case of any clarification Thank you BridgeLabz 01/01/2016.";
            string str1 = "";
            Console.WriteLine("Enter the your full name");
            string name = Console.ReadLine();
            string mid = Console.ReadLine();
            string last = Console.ReadLine();

            if (isString(name + mid + last))
            {
                Console.WriteLine("Enter the mobile no");
                string number=Console.ReadLine();
                if (isMobileNumber(number) && number.Length == 10)
                {
                    Regex pn = new Regex("<<name>>");
                    Regex fn = new Regex("<<fullname>>");
                    Regex mo = new Regex("xxxxxxxxxx");
                    Regex date = new Regex("01/01/2022");
                }
            }
        }
    }
}
