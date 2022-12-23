using BaiTapDanhGiaCSharp;

//Bai 1
int[] nums = new int[] { 3,30,34,5,9 };
Console.WriteLine($"Output: {bai1.FindMissingNumber(nums)}");

//Bai 2
nums = new int[] { 2,0,2,1,1,0 };
bai2.sort(nums);
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"{nums[i]} ");
}
Console.WriteLine();


//Bai 3
nums = new int[] { 3,77,100,34,5,9 };

Console.WriteLine($"Output: {bai3.SortAndMergeIntoMax(nums)}");


