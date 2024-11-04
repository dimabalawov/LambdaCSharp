namespace Anonymous_methods
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int[] numbers = { -1, -2, -3, -2, -4, -1, -5, 3, 4, -3, -6 };

            var newarr = numbers.Where(n => n < 0).Distinct();

            Console.WriteLine("Уникальные отрицательные числа в массиве:");
            foreach(var n in newarr) Console.WriteLine(n);

        }
    }
}