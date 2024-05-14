// Delegates 

public delegate void delegateForCalculateWIthoutParameter();
public delegate void delegateForcalculateSquareWithParameter(int a);
public delegate void delegateForCalculateSubstractWithParameter(int a, int b);

class MathCalculation
{
    public static void calculateWIthoutParameter()
    {
        Console.WriteLine("this is the function made for learning delegate without parameter");
    }
    public static void calculateWIthoutParameter2()
    {
        Console.WriteLine("this is the function2 made for learning delegate without parameter");
    }
    public static void calculateSquareWithParameter(int num)
    {
        int result = num * num;
        Console.WriteLine($"the square of num is: {result}");
    }
    public static void calculateSubstractWithParameter(int num1, int num2)
    {
        int result = Math.Abs(num1 - num2);
        Console.WriteLine($"the substract of numbers is: {result}");
    }
    public static void calculateSumWithParameter(int num1, int num2)
    {
        int result = Math.Abs(num1 + num2);
        Console.WriteLine($"the substract of numbers is: {result}");
    }

}



class Program
{
    static void Main(string[] args)
    {

        //Multiple delegate using one delegate
        delegateForCalculateWIthoutParameter delegate1 = new delegateForCalculateWIthoutParameter(MathCalculation.calculateWIthoutParameter);
        //delegate1.Invoke();
        delegate1 = MathCalculation.calculateWIthoutParameter2;
        //delegate1.Invoke();

        // Single Delegate
        delegateForcalculateSquareWithParameter delegate2 = new delegateForcalculateSquareWithParameter(MathCalculation.calculateSquareWithParameter);
        //delegate2.Invoke(2);

        delegateForCalculateSubstractWithParameter delegate3 = new delegateForCalculateSubstractWithParameter(MathCalculation.calculateSubstractWithParameter);
        //delegate3(5,1);


        //Multicast Delegate
        delegate3 += MathCalculation.calculateSumWithParameter;
        delegate3(2, 6);

        
    }
}