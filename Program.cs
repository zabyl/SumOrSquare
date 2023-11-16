
internal class Program
{
    private static void Main(string[] args)
    {
        NumCount();
    }

    static void NumCount()
    {
        Console.WriteLine("How many number pairs do you want to check?");
        int numCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You will check {numCount} pairs.");

        int[] nums = new int [numCount];
        int counter = 0;
        
        while (numCount > 0)
        {
            Console.WriteLine("Enter first number of the pair: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number of the pair: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int sumOfPair = firstNum + secondNum;

            if (firstNum == secondNum)
            {
                nums[counter] = sumOfPair * sumOfPair;
            }
            else
            {
                nums[counter] = sumOfPair;
            }

            counter++;
            numCount--;
        }

        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }
    }
}