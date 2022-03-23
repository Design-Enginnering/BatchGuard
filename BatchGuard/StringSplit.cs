﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BatchGuard
{
    public class StringSplit
    {
        public static string GenCode(string input, Random rng, bool stringsubenabled, int level = 5)
        {
            string ret = string.Empty;
            string[] lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            int amount = 5;
            if (level > 1) amount -= level;

            List<string> setlines = new List<string>();
            List<string[]> linevars = new List<string[]>();
            foreach (string line in lines)
            {
                List<string> splitted = new List<string>();
                string sc = string.Empty;
                bool invar = false;
                int i = 0;
                if (stringsubenabled)
                {
                    foreach (char c in line)
                    {
                        if (c == '%') invar = !invar;
                        if (invar)
                        {
                            sc += c;
                        }
                        else
                        {
                            sc += c;
                            i++;
                            if (i >= amount * 2)
                            {
                                splitted.Add(sc);
                                sc = string.Empty;
                                i = 0;
                            }
                        }
                    }
                    splitted.Add(sc);
                }
                else
                {
                    foreach (char c in line)
                    {
                        if (c == '%')
                        {
                            invar = !invar;
                            sc += c;
                            continue;
                        }
                        if (!invar)
                        {
                            if (sc.Length >= amount * 2)
                            {
                                splitted.Add(sc);
                                sc = string.Empty;
                            }
                        }
                        sc += c;
                    }
                    splitted.Add(sc);
                }

                List<string> vars = new List<string>();
                foreach (string s in splitted)
                {
                    string name = $"BGUARD_{ Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", "").Replace("+", "").Substring(0, 8)}";
                    setlines.Add($"set \"{name}={s}\"{Environment.NewLine}");
                    vars.Add(name);
                }
                linevars.Add(vars.ToArray());
            }

            foreach (string sl in setlines.OrderBy(x => rng.Next()).ToArray()) ret += sl; // Write all variables in random order

            // Call all variables in correct order
            foreach (string[] line in linevars)
            {
                foreach (string s in line) ret += $"%{s}%";
                ret += Environment.NewLine;
            }

            return ret;
        }
    }
}