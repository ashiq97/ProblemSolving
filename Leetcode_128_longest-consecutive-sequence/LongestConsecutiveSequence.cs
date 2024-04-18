namespace Leetcode_128_longest_consecutive_sequence
{
    public class LongestConsecutiveSequence
    {
        public static int GetResult()
        {
            //var nums = new int[6] { 100, 4, 200, 1, 3, 2 };
            // var nums = new int[2] { 0,0 };
            //var nums = new int[1] { 0 };
            // var nums = new int[10] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
            var nums = new int[11] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };
            var result = LongestConsecutive(nums);

            return result;
        }
        public static int LongestConsecutive(int[] nums)
        {
            if(nums.Length == 0) return 0;
            Array.Sort(nums);
            var count = 1;
            for(long i = 0;i<nums.Length-1;i++)
            {
                if ((nums[i+1] - nums[i] == 1))
                      {
                    count++;
                }
            }

            Console.WriteLine(count);
            return 0;
        }
    }
}
