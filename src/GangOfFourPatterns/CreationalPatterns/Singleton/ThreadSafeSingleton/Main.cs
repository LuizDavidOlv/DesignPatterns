﻿using System;
using System.Threading;

namespace src.GangOfFourPatterns.CreationalPatterns.Singleton.ThreadSafeSingleton
{
    public class ThreadSafeSingleton
    {
        public static void Execute()
        {
            // The client code.

            Console.WriteLine(
                    "{0}\n{1}\n\n{2}\n",
                    "If you see the same value, then singleton was reused (yay!)",
                    "If you see different values, then 2 singletons were created (booo!!)",
                    "RESULT:"
                );

            Thread process1 = new(() =>
            {
                TestSingleton("FOO");
            });

            Thread process2 = new(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
