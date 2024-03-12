// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Console.WriteLine("Hello, World!");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("hehehe");
}


static double getAvg(int[] nums)
{
    int sum = 0;
    foreach (var num in nums)
    {
        sum += num;
    }

    return (double) sum / nums.Length;
}

int[] tab = {1,2,3,4};
double avg = getAvg(tab);
Console.WriteLine(avg);