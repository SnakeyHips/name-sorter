using name_sorter.Contracts.Helpers;
using name_sorter.Contracts.Models;
using name_sorter.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

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
            if(Names.Count > 1)
            {
                try
                {
                    Names = Names.OrderBy(n => n.LastName).ThenBy(n => n.FirstNames).ToList();
                    return true;
                }
                catch (Exception e)
                {
                    this.logHelper.LogException(e);
                    return false;
                }
            }
            else
            {
                this.logHelper.LogMessage("No names provided!");
                return false;
            }
        }
    }
}
