using name_sorter.Helpers;
using name_sorter.ViewModels;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var arg in args)
            {
                NameViewModel nameViewModel = new NameViewModel();
                nameViewModel.Names = FileHelper.ReadFile(arg);
                if (nameViewModel.SortNames())
                {
                    LogHelper.LogNames(nameViewModel.Names);
                }
                else
                {
                    LogHelper.LogMessage("Failed to sort!");
                }
                if (FileHelper.WriteFile("./sorted-names-list.txt", nameViewModel.Names))
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
}
