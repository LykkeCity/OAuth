﻿using System;
using System.Threading.Tasks;

namespace Common.Log
{
    public class LogToConsole : ILog
    {
        public Task WriteInfoAsync(string component, string process, string context, string info, DateTime? dateTime = null)
        {
            Console.WriteLine("---------LOG INFO-------");
            Console.WriteLine("Component: "+ component);
            Console.WriteLine("Process: " + process);
            Console.WriteLine("Context: " + context);
            Console.WriteLine("Info: " + info);
            Console.WriteLine("---------END LOG INFO-------");
            return Task.FromResult(0);
        }

        public Task WriteWarningAsync(string component, string process, string context, string info, DateTime? dateTime = null)
        {
            Console.WriteLine("---------LOG WARNING-------");
            Console.WriteLine("Component: " + component);
            Console.WriteLine("Process: " + process);
            Console.WriteLine("Context: " + context);
            Console.WriteLine("Info: " + info);
            Console.WriteLine("---------END LOG INFO-------");
            return Task.FromResult(0);
        }

        public Task WriteErrorAsync(string component, string process, string context, Exception exeption, DateTime? dateTime = null)
        {
            Console.WriteLine("---------LOG ERROR-------");
            Console.WriteLine("Component: " + component);
            Console.WriteLine("Process: " + process);
            Console.WriteLine("Context: " + context);
            Console.WriteLine("Message: " + exeption.Message);
            Console.WriteLine("Stack: " + exeption.StackTrace);
            Console.WriteLine("---------END LOG INFO-------");
            return Task.FromResult(0);
        }


        public Task WriteFatalErrorAsync(string component, string process, string context, Exception exeption, DateTime? dateTime = null)
        {
            Console.WriteLine("---------LOG FATALERROR-------");
            Console.WriteLine("Component: " + component);
            Console.WriteLine("Process: " + process);
            Console.WriteLine("Context: " + context);
            Console.WriteLine("Message: " + exeption.Message);
            Console.WriteLine("Stack: " + exeption.StackTrace);
            Console.WriteLine("---------END LOG INFO-------");
            return Task.FromResult(0);
        }

        public int Count { get { return 0; } }
    }
}
