namespace _3_problems_in_LeetCode
{
    internal class Program
    {
        static int IndexOfNeedleInHaystack(string needle, string haystack)
        {
            int index = haystack.IndexOf(needle);
            return index;
        }
        static void Main(string[] args)
        {
            string needle = " ";
            string heystack = " ";
            Console.WriteLine("please writer heystack:");
            heystack = Console.ReadLine();
            Console.WriteLine("please writer needle:");
            needle = Console.ReadLine();
            int result = IndexOfNeedleInHaystack(needle, heystack);

            if (result >= 0)
            {
                Console.WriteLine($"The needle was found at index: {result}");
            }
            else
            {
                Console.WriteLine("The needle was not found in the haystack.");
            }
        }
    }
}