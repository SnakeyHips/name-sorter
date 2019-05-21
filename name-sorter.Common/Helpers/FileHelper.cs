using name_sorter.Common.Models;
using name_sorter.Contracts.Helpers;
using name_sorter.Contracts.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter.Common.Helpers
{
    public class FileHelper : IFileHelper
    {
        ILogHelper logHelper;

        public FileHelper(ILogHelper logHelper)
        {
            this.logHelper = logHelper;
        }

        public List<IName> ReadFile(string filename)
        {
            List<IName> names = new List<IName>();
            if (filename != string.Empty)
            {
                try
                {
                    using (StreamReader sr = File.OpenText(Path.Combine(Environment.CurrentDirectory, filename)))
                    {
                        string s = String.Empty;
                        while ((s = sr.ReadLine()) != null)
                        {
                            string[] temp = s.Split(" ");
                            names.Add(new Name()
                            {
                                FirstNames = string.Join(" ", temp.SkipLast(1).ToArray()),
                                LastName = temp[temp.Length - 1]
                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    this.logHelper.LogException(e);
                }

            }
            return names;
        }

        public bool WriteFile(string filename, List<IName> names)
        {
            if(filename != string.Empty)
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.CurrentDirectory, filename)))
                {
                    try
                    {
                        foreach (Name n in names)
                        {
                            sw.WriteLine(n.FirstNames + " " + n.LastName);
                        }
                        return true;
                    }
                    catch (Exception e)
                    {
                        this.logHelper.LogException(e);
                        return false;
                    }

                }
            }
            else
            {
                return false;
            }
        }
    }
}
