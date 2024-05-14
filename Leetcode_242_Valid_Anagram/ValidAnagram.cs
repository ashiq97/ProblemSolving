using System.Linq;

namespace Leetcode_242_Valid_Anagram
{
    public class ValidAnagram
    {
        public static bool GetResult()
        {
            var s = "aacc";
            var t = "ccac";

            var result = IsAnagram(s,t);

            return result;
        }

        // solution 1:

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var sArray = s.ToArray();
            var tArray = t.ToArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            var n1 = new String(sArray);
            var n2 = new String(tArray);

            if (n1 == n2)
                return true;
            else
                return false;

        }

        // solution 2:
        //public static bool IsAnagram(string s, string t)
        //{
        //  if(s.Length != t.Length) 
        //        return false;

        //    var slist = new Dictionary<char,int>();
        //    var tlist = new Dictionary<char,int>();

        //    var count = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (!slist.ContainsKey(s[i]))
        //            slist.Add(s[i], 0);

        //        if (!tlist.ContainsKey(t[i]))
        //            tlist.Add(t[i], 0);
        //    }

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        slist[s[i]] = slist[s[i]] + 1;
        //        tlist[t[i]] = tlist[t[i]] + 1;
        //    }

        //    for(int i = 0;i<s.Length;i++)
        //    {
        //        if (!slist.ContainsKey(t[i]))
        //            return false;

        //         if(slist[t[i]] != tlist[t[i]])
        //            return false;
        //    }

        //    return true;
        //}

        // solution 3:
        //public static bool IsAnagram(string s, string t)
        //{

        //}
    }
}
