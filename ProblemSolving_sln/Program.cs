﻿// See https://aka.ms/new-console-template for more information
using Leetcode_125_Valid_Palindrome;
using Leetcode_128_longest_consecutive_sequence;
using Leetcode_217_Contains_Duplicate;
using Leetcode_242_Valid_Anagram;

//1. Leetcode 217
var ContainsDuplicate_result = ContainsDuplicate.GetResult();
Console.WriteLine(ContainsDuplicate_result);

//2. Leetcode 242
var IsAngram_result = ValidAnagram.GetResult();
Console.WriteLine(IsAngram_result);

//3. Leetcode 128
var LongestConsecutive_result = LongestConsecutiveSequence.GetResult();
Console.WriteLine(LongestConsecutive_result);

//4.Leetcode 125
var IsPalindrome_result = ValidPalindrome.IsPalindrome();
Console.WriteLine(IsPalindrome_result);