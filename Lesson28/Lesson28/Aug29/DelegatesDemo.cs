/*using System.Reflection;

public delegate void MethodHandlerA();
public delegate void  MethodHandlerB(int x, int y);

public class MathCalculater
{
    public class Pointer
    {
        public void DoTask()
        {
            Console.WriteLine("Calculater DoTask");
        }
        public int Add(int x, int y)
        {
            Console.WriteLine(x + "," + y);
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            Console.WriteLine(x + "," + y);
            return x * y;
        }
        public int Divide(int x, int y)
        {
            Console.WriteLine(x + "," + y);
            return x / y;
        }
        public string GetMode()
        {
            return "X500";
        }
    }
    
 
}

    public class Delegatedemo
    {
        public static void  TestOne()
        {
            MathCalculater mc = new MathCalculater();
             MethodHandlerA methodHandlerA = new MethodHandlerA(mc.DoTask);
             MethodHandlerB methodHandlerB = new MethodHandlerB(mc.Add);
             MethodHandlerB methodHandlerTwo = new MethodHandlerB(mc.Multiply);
            // MethodHandlerB methodHandlerThree = new MethodHandlerB(mc.Divide);   // Illegal
            methodHandlerA();
            int addResult = methodHandlerB(100, 50);
            Console.WriteLine(addResult);
            int multiplyResult = methodHandlerTwo(20, 5);
            Console.WriteLine(multiplyResult);
        }
    }
}
*/
    