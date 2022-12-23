namespace BaiTapDanhGiaCSharp;

public class bai1
{
    public static int FindMissingNumber(int[] nums)
    {
        int n = nums.Max();
        int RealSum = (n * (n + 1)) / 2;
        int FakeSum = nums.Sum();
        return RealSum - FakeSum;
    }
}