using name_sorter.Contracts.Models;
using System.Collections.Generic;

namespace name_sorter.Contracts.ViewModels
{
    public interface INameViewModel
    {
        List<IName> Names { get; }

        bool SortNames();
    }
}
