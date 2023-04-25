using System;

namespace Static_Smith_Luke
{
    static class Calculate
    {
        //these methods add two numbers, one handles ints one handles floats
        public static int AddNum(int x, int y)
        {
            return x + y;
        }
        public static float AddNum(float x, float y)
        {
            return x + y;
        }
        //these methods multiply two numbers, one handles ints one handles floats
        public static int MultNum(int x, int y)
        {
            return x * y;
        }
        public static float MultNum(float x, float y)
        {
            return x * y;
        }
        //these methods subtract two numbers, one handles ints one handles floats
        public static int MinNum(int x, int y)
        {
            return x - y;
        }
        public static float MinNum(float x, float y)
        {
            return x - y;
        }
        //these methods divides two numbers, one handles ints one handles floats
        public static int DivNum(int x, int y)
        {
            return x / y;
        }
        public static float DivNum(float x, float y)
        {
            return x / y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the result of all the static methods I made");
            //this writes the result of the static methods with predetermined numbers 
            Console.WriteLine(Calculate.AddNum(1, 3));
            Console.WriteLine(Calculate.AddNum(1f, 2f));
            Console.WriteLine(Calculate.MinNum(1, 3));
            Console.WriteLine(Calculate.MinNum(1f, 2));
            Console.WriteLine(Calculate.MultNum(2, 3));
            Console.WriteLine(Calculate.MultNum(2f, 4f));
            Console.WriteLine(Calculate.DivNum(4, 2));
            Console.WriteLine(Calculate.DivNum(6f, 2f));
        }
    }
}
