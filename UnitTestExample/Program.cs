public class UnitTestExample
{
    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] ret = UnitTestExample.TwoSum(nums, target);
        Console.WriteLine($"[{ret[0]},{ret[1]}]");

    } // EOM


    /// <summary>
    /// return the indecies of the first set of two numbers added together to equal the target number
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns>Indices of two numbers that add to the target number</returns>
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int x = 0; x < nums.Length; x++)
        {
            for (int y = 0; y < nums.Length; y++)
            {
                // if the x and y are the same we are looking at the same value in the array
                if (x == y)
                    continue;

                if (nums[x] + nums[y] == target)
                {
                    // return at the first set which add to the target, all following results are ignored
                    return new int[] { x, y };
                }
            }
        }

        return new int[] { 0, 0 };
    } // EOM
} // EOC