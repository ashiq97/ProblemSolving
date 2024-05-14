namespace Leetcode_125_Valid_Palindrome
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome()
        {
            var s = "A man, a plan, a canal: Panama";
            var ss = "race  car";
            var sss = " ";
            var s4 = "0P";

            var result = CheckIsPalindrome(s4);
            return result;
        }
        public static bool CheckIsPalindrome(string s)
        {
            var list = new Stack<char>();
            
            if (string.IsNullOrWhiteSpace(s))
                return true;

            foreach(var item in s.ToLower())
            {
                if(item >= 'a' && item <= 'z' || char.IsDigit(item))
                {
                    list.Push(item);
                }
            }

            foreach(var item in s.ToLower())
            {
                if (item >= 'a' && item <= 'z' || char.IsDigit(item))
                {
                    var originalItem = list.Pop();

                    if (item != originalItem)
                        return false;
                        
                }
            }

            return true;
        }


    }
}