using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuard
{
    public class StringSub
    {
        private static string lsetname;
        private static string ulsetname;
        private static string numsetname;

        private static string letterset;
        private static string upletterset;
        private static string numberset;

        private static string letchars = "abcdefghijklmnopqrstuvwxyz";
        private static string letupchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string numchars = "0123456789";

        public static string GenVars(Random rng)
        {
            lsetname = $"BGUARD_{Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", "").Replace("+", "").Substring(0, 10)}";
            ulsetname = $"BGUARD_{Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", "").Replace("+", "").Substring(0, 10)}";
            numsetname = $"BGUARD_{Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", "").Replace("+", "").Substring(0, 10)}";

            letterset = new string(letchars.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
            upletterset = new string(letupchars.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
            numberset = new string(numchars.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());

            StringBuilder varcode = new StringBuilder();
            int[] setorder = new int[] { 1, 2, 3 }.OrderBy(x => rng.Next()).ToArray();
            foreach (int s in setorder)
            {
                switch (s)
                {
                    case 1:
                        varcode.AppendLine($"set {lsetname}={letterset}");
                        break;
                    case 2:
                        varcode.AppendLine($"set {ulsetname}={upletterset}");
                        break;
                    case 3:
                        varcode.AppendLine($"set {numsetname}={numberset}");
                        break;
                }
            }

            return varcode.ToString();
        }

        public static string GenCode(string input, Random rng)
        {
            string ret = string.Empty;
            bool invar = false;
            foreach (char c in input)
            {
                if (c == '%') invar = !invar;
                if (invar)
                {
                    if (char.IsLetter(c))
                    {
                        int r = rng.Next(0, 2);
                        if (r == 0) ret += char.ToUpper(c);
                        else ret += char.ToLower(c);
                    }
                    else ret += c;
                    continue;
                }
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c)) ret += $"%{ulsetname}:~{upletterset.IndexOf(c)},1%";
                    else ret += $"%{lsetname}:~{letterset.IndexOf(c)},1%";
                }
                else if (char.IsDigit(c)) ret += $"%{numsetname}:~{numberset.IndexOf(c)},1%";
                else ret += c;
            }
            return ret;
        }
    }
}
