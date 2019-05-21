using name_sorter.Contracts.Models;
using System.Collections.Generic;

namespace name_sorter.Contracts.Helpers
{
    public interface IFileHelper
    {
        List<IName> ReadFile(string filename);

        bool WriteFile(string filename, List<IName> names);
    }
}
