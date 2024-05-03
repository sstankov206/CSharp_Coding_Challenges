public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            string? input = Console.ReadLine();

            double[] inputArr =// JsonSerializer.Deserialize<int[]>(input);
                input.Split(", ").Select(double.Parse).ToArray();
            var smallestNumber = FindSmallestNum(inputArr);

            Console.WriteLine(smallestNumber);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Please enter valid input");
            Main(args);

        }
    }

    public static double FindSmallestNum(double[] arr)
    {
        if (arr == null || arr.Length < 1)
        {
            throw new ArgumentNullException();
        }

        double smallestNum = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < smallestNum)
            {
                smallestNum = arr[i];
            }
        }
        return smallestNum;
    }
}