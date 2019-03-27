using System;

class Program
{
    public static double  Hypotenuse(Values value )
    {
        return Math.Sqrt(value.x * value.x + value.y * value.y);      
    }
    static void PiLoop(int length)
    {
        double[] array = new double[length];

        Random randomValue = new Random();
        double count = 0;
        for (int i = 0; i < length; i++)
        {
            Values structValues = new Values(randomValue);
            array[i] = Hypotenuse(structValues );
            if(array[i] <= 1)
            {
                count += 1;
            }
        }
        double LastCount = (count / array.Length) * 4;
        Console.WriteLine($"The estimate of pi is {LastCount}");
        Console.WriteLine($"The difference of the absolute value and Pi is: {Math.Abs(LastCount - Math.PI)}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a number to place random point in the hypotenuse: ");
        int randomPoints = Convert.ToInt32(Console.ReadLine());
        PiLoop(randomPoints);
        Console.ReadLine();     
    }

    public struct Values
    {
        public double x, y;
        public Values (double xCoord, double yCoord)
        {
            x = xCoord;
            y = yCoord;         
        }
        public Values(Random random)
        {
            x = random.NextDouble();
            y = random.NextDouble();
        }
    }
  

}