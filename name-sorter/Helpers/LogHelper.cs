using name_sorter.Models;
using System;
using System.Collections.Generic;

namespace name_sorter.Helpers
{
    public class LogHelper
    {
        public static void LogException(Exception e)
        {
            Console.WriteLine(e);
        }

        public static void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogNames(List<Name> names)
        {
            foreach (Name n in names)
            {
                Console.WriteLine(n.FirstNames + " " + n.LastName);
            }
        }
    }
}
