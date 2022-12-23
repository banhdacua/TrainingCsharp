namespace BaiTapDanhGiaCSharp;

public class bai3
{
    static int FirstNumber(int number)
    {
        int tempVar = 0;
        while (number > 0)
        {
            tempVar = number % 10;
            number = number / 10;
        }
    
        return tempVar;
    }


    public static String SortAndMergeIntoMax(int[] nums)
    {
        int[] n;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (FirstNumber(nums[i]) <= FirstNumber(nums[j]))
                {
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    
        String maxNum = "";
        foreach (var VARIABLE in nums)
        {
            maxNum = maxNum + VARIABLE.ToString();
        }
    
        return maxNum;
    }
}