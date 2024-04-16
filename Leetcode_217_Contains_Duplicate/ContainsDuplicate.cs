using System.Collections.Generic;

namespace Leetcode_217_Contains_Duplicate
{
    public class ContainsDuplicate
    {
        public static bool GetResult()
        {
            var numbers = new int[4] {1,2,3,1};
            //var numbers = new int[4] {1,2,3,4};

            var result = CheckDuplicate(numbers);
            return result;
        }
        public static bool CheckDuplicate(int[] nums)
        {
            var list = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (!list.ContainsKey(item))
                    list[item] = item;
                else
                    return true;
            }

            return false;

        }

        // another Approach (may be it is better than using Dictionary)

        //public static bool CheckDuplicate(int[] nums)
        //{
        //    var list = new HashSet<int>();

        //    foreach (var item in nums)
        //    {
        //        if (!list.Contains(item))
        //            list.Add(item);
        //        else
        //            return true;
        //    }

        //    return false;
        //}


    }
}
