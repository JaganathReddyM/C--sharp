

// What are Value types? Declare a variable for each Value type, and print its Max Value.

/**

  * Value types are predefined datatypes in C#

  * Value types are loaded in the stack

  * Value types need not be instantiated

  * Value types have default value

  * Value types can not be set to NULL

  * Value types contain value in the memory allocated to them

  * When a value type is assigned to another value type a copy of the value will be created

  * Struct and Enums are Value types

  */

namespace codef
{
    public class a1
    {


        public static void QuestionOne()

        {

            byte byteOne = 1;

            sbyte sbyteOne = 1;

            short shortOne = 1;

            int intOne = 1;

            long longOne = 1;

            float floatOne = 1.543f;

            double doubleOne = 2345.76534d;

            decimal decimalOne = 627637263.36263726372M;

            char charOne = 'A';

            bool boolOne = true;

            Console.WriteLine(byte.MaxValue);

            Console.WriteLine(sbyte.MaxValue);

            Console.WriteLine(short.MaxValue);

            Console.WriteLine(int.MaxValue);

            Console.WriteLine(long.MaxValue);

            Console.WriteLine(float.MaxValue);

            Console.WriteLine(double.MaxValue);

            Console.WriteLine(decimal.MaxValue);

        }
    }
}