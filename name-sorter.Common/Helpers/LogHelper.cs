using name_sorter.Contracts.Helpers;
using name_sorter.Contracts.Models;
using System;
using System.Collections.Generic;

namespace name_sorter.Common.Helpers
{
    public class LogHelper : ILogHelper
    {
        public void LogException(Exception e)
        {
            Console.WriteLine(e);
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void LogNames(List<IName> names)
        {
            foreach (IName n in names)
            {
                Console.WriteLine(n.FirstNames + " " + n.LastName);
            }
        }
    }
}
