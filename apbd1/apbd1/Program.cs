// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Console.WriteLine("Hello, World!");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("hehehe");
}


static double getAvgWeird(int[] nums)
{
    int sum = 0;
    foreach (var num in nums)
    {
        sum += num;
    }

    return (double) sum / nums.Length;
}

int[] tab = {1,2,3,4};
double avg = getAvgWeird(tab);
Console.WriteLine(avg);

static int maxVal (int[] nums)
{
    int max = nums[0];
    foreach (var num in nums)
    {
        if (num > max)
        {
            max = num;
        }
    }

    return max;
}