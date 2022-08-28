using TwoSum;

int[] array = { 2,7,11,15};

TwoSumImplement twoSum = new TwoSumImplement();

int[] result = twoSum.TwoSum(array, 9);

foreach (var item in result)
{
    Console.WriteLine(item);
}