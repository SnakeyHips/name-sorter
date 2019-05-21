using name_sorter.Contracts.Models;
using System;
using System.Collections.Generic;

namespace name_sorter.Contracts.Helpers
{
    public interface ILogHelper
    {
        void LogException(Exception e);

        void LogMessage(string message);

        void LogNames(List<IName> names);
    }
}
