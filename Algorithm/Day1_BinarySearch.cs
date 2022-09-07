namespace Algorithm_I
{
    public class Day1_BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            Array.Sort(nums);
            var index = 0;

            if (nums.Contains(target))
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                    {
                        index = Array.IndexOf(nums, nums[i]);
                    }
                }
            }
            else
            {
                index = -1;
            }
            
            return index;
        }
    }
}