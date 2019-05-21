using name_sorter.Helpers;
using name_sorter.Models;
using System;
using System.Collections.Generic;

namespace name_sorter.ViewModels
{
    public class NameViewModel
    {
        public List<Name> Names { get; set; }

        public NameViewModel()
        {
            Names = new List<Name>();
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
                LogHelper.LogException(e);
                return false;
            }
        }
    }
}
