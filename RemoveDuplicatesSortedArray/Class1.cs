namespace RemoveDuplicatesSortedArray;
public class Class1
{

    public int RemoveDuplicates(int[] nums)
    {
        int index = 1;
        foreach (int i in nums)
        {
            if (nums[index - 1] != i)
            {
                nums[index++] = i;
            }
        }
        return index;
    }

}
