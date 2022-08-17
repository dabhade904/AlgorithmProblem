namespace AlgorithmProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            Console.WriteLine("\n 1. Insertion Sort \n 2. Anagram string \n 3.Prime Palindrome \n 4. Palindrome checker \n 5. Bubble Sort \n 6.Guess Number");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:
                    Algorithms.InsertionSort();
                    break;
                case 2:
                    string first = "geeksforgeeks";
                    string second = "forgeeksgeeks";
                    Algorithms.anagramString(first, second);
                    break;
                case 3:
                    Console.WriteLine("Enter the limit");
                    int limit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Prime palindrome are");
                    Algorithms.PrintPrime(limit);
                    break;
                case 4:
                    Console.WriteLine("Enter number to check palindrome or not");
                    int palindromeCheck = Convert.ToInt32(Console.ReadLine());
                    Algorithms.Palindrome(palindromeCheck);
                    break;
                case 5:
                    int[] arr = { 20, 54, 24, 65, 76, 21, 45 };
                    Algorithms.BubbleSort(arr);
                    Console.WriteLine("Sorted Array are");
                    Algorithms.Display(arr);
                    break;
                case 6:
                    Console.WriteLine("Enter the lower value");
                    int low = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the high value");
                    int high = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("guess is" + Algorithms.GuessNumber(low, high));
                    break;
            }
        }
    }
}