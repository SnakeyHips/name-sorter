using name_sorter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter.Helpers
{
    public class FileHelper
    {
        public static List<Name> ReadFile(string filename)
        {
            List<Name> names = new List<Name>();
            using (StreamReader sr = File.OpenText(Path.Combine(Environment.CurrentDirectory, "./" + filename)))
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
            return names;
        }

        public static bool WriteFile(string filename, List<Name> names)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "./" + filename)))
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
                    LogHelper.LogException(e);
                    return false;
                }

            }
        }
    }
}
