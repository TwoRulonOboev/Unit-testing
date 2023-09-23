using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] testCases = { 10, 20, 50, 100, 200 };
            int[] expectedResults = { 4, 8, 15, 25, 46 };

            for (int i = 0; i < testCases.Length; i++)
            {
                int result = PrimeNumberCounter.CountPrimeNumbers(testCases[i]);

                if (result == expectedResults[i])
                    Console.WriteLine($"Тестовый случай {i + 1}: Пройден");
                else
                    Console.WriteLine($"Тестовый случай {i + 1}: Не пройден. Ожидаемый результат: {expectedResults[i]}, Фактический результат: {result}");
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] testCases = { 30, 50, 75, 120 };
            int[] expectedResults = { 10, 15, 21, 30 };
            for (int i = 0; i < testCases.Length; i++)
            {
                int result = PrimeNumberCounter.CountPrimeNumbers(testCases[i]);
                if (result == expectedResults[i])
                    Console.WriteLine($"Тестовый случай {i + 6}: Пройден");
                else
                    Console.WriteLine($"Тестовый случай {i + 6}: Не пройден. Ожидаемый результат: {expectedResults[i]}, Фактический результат: {result}");
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] testCases = { 30, 50, 75, 120 };
            int[] expectedResults = { 10, 15, 21, 30 };
            for (int i = 0; i < testCases.Length; i++)
            {
                int result = PrimeNumberCounter.CountPrimeNumbers(testCases[i]);
                if (result == expectedResults[i])
                    Console.WriteLine($"Тестовый случай {i + 6}: Пройден");
                else
                    Console.WriteLine($"Тестовый случай {i + 6}: Не пройден. Ожидаемый результат: {expectedResults[i]}, Фактический результат: {result}");
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] testCases = { 10, 45, 100 };
            int[] expectedResults = { 4, 14, 25 };
            for (int i = 0; i < testCases.Length; i++)
            {
                int result = PrimeNumberCounter.CountPrimeNumbers(testCases[i]);
                if (result == expectedResults[i])
                    Console.WriteLine($"Тестовый случай {i + 9}: Пройден");
                else
                    Console.WriteLine($"Тестовый случай {i + 9}: Не пройден. Ожидаемый результат: {expectedResults[i]}, Фактический результат: {result}");
            }
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] testCases = { 15, 35 };
            int[] expectedResults = { 6, 11 };
            for (int i = 0; i < testCases.Length; i++)
            {
                int result = PrimeNumberCounter.CountPrimeNumbers(testCases[i]);
                if (result == expectedResults[i])
                    Console.WriteLine($"Тестовый случай {i + 13}: Пройден");
                else
                    Console.WriteLine($"Тестовый случай {i + 13}: Не пройден. Ожидаемый результат: {expectedResults[i]}, Фактический результат: {result}");
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] testCases = { 60, 90 };
            int[] expectedResults = { 17, 24 };
            for (int i = 0; i < testCases.Length; i++)
            {
                int result = PrimeNumberCounter.CountPrimeNumbers(testCases[i]);
                if (result == expectedResults[i])
                    Console.WriteLine($"Тестовый случай {i + 15}: Пройден");
                else
                    Console.WriteLine($"Тестовый случай {i + 15}: Не пройден. Ожидаемый результат: {expectedResults[i]}, Фактический результат: {result}");
            }
        }
    }
    public class PrimeNumberCounter
    {
        public static int CountPrimeNumbers(int N)
        {
            int count = 0;
            for (int i = 2; i <= N; i++)
            {
                if (IsPrime(i))
                    count++;
            }
            return count;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}

