using name_sorter.Contracts.Helpers;
using name_sorter.Contracts.Models;
using name_sorter.Contracts.ViewModels;
using System;
using System.Collections.Generic;

namespace name_sorter.Common.ViewModels
{
    public class NameViewModel : INameViewModel
    {
        public List<IName> Names { get; set; }

        ILogHelper logHelper;

        public NameViewModel(ILogHelper logHelper)
        {
            Names = new List<IName>();
            this.logHelper = logHelper;
        }

        public bool SortNames()
        {
            try
            {
                Names.Sort((a, b) => a.LastName.CompareTo(b.LastName));
                return true;
            }
            catch (Exception e)
            {
                this.logHelper.LogException(e);
                return false;
            }
        }
    }
}
