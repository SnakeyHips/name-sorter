using name_sorter.Helpers;
using name_sorter.Models;
using name_sorter.ViewModels;
using System;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            NameViewModel nameViewModel = new NameViewModel();
            nameViewModel.Names = FileHelper.ReadFile("unsorted-names-list.txt");
            if (nameViewModel.SortNames())
            {
                LogHelper.LogNames(nameViewModel.Names);
            } 
            else
            {
                LogHelper.LogMessage("Failed to sort!");
            }
            if (FileHelper.WriteFile("sorted-names-list.txt", nameViewModel.Names))
            {
                LogHelper.LogMessage("Sorted list text file written successfully!");
            }
            else
            {
                LogHelper.LogMessage("Sorted list text file written failed!");
            }
            
        }
    }
}
