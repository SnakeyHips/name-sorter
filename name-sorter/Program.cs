using name_sorter.Common.Helpers;
using name_sorter.Common.ViewModels;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise Helpers
            LogHelper logHelper = new LogHelper();
            FileHelper fileHelper = new FileHelper(logHelper);

            foreach(var arg in args)
            {
                // Intialise ViewModel
                NameViewModel nameViewModel = new NameViewModel(logHelper);

                // Read file from args then sort names
                nameViewModel.Names = fileHelper.ReadFile(arg);
                if (nameViewModel.SortNames())
                {
                    logHelper.LogNames(nameViewModel.Names);
                    // Write sorted names to file
                    if (fileHelper.WriteFile("./sorted-names-list.txt", nameViewModel.Names))
                    {
                        logHelper.LogMessage("Sorted list text file written successfully!");
                    }
                    else
                    {
                        logHelper.LogMessage("Sorted list text file written failed!");
                    }
                }
                else
                {
                    logHelper.LogMessage("Failed to sort!");
                }
            }            
        }
    }
}
