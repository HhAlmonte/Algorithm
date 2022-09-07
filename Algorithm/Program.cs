namespace Algorithm_I
{
    public class Program
    {
        static void Main(string[] args)
        {
            Day1_BinarySearch day1_BinarySearch = new Day1_BinarySearch();

            int[] nums = new int[] { -1, 0, 3, 5, 9, 12 };

            var result = day1_BinarySearch.Search(nums, 2);
            Console.WriteLine(result);
        }
    }
}