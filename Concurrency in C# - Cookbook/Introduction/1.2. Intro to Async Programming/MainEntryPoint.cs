﻿namespace IntroToAsyncProgramming
{
    using System;
    using System.Threading.Tasks;

    public class MainEntryPoint
    {
        internal static void Main()
        {
            MainEntryPoint.DoSomeWork();
            MainEntryPoint.DoSomeWork();

            Console.ReadLine();
        }

        internal static async Task DoSomeWork()
        {
            Console.WriteLine(1);

            await Task.Delay(3000);

            Console.WriteLine(2);

            await Task.Delay(1000);

            Console.WriteLine(3);
        }
    }
}