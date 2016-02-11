using System;

namespace delegateExample
{
    internal delegate int NumberChanger(int n);

    internal static class Program
    {
        private static int _num = 10;

        private static int AddNum(int p)
        {
            _num += p;
            return _num;
        }

        private static int MultNum(int q)
        {
            _num *= q;
            return _num;
        }

        private static int GetNum()
        {
            return _num;
        }

        private static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc1 = AddNum;
            NumberChanger nc2 = MultNum;
            var nc3 = AddNum(5);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", GetNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", GetNum());
            Console.ReadKey();
        }
    }
}