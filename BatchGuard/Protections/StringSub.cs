using System;
using System.Linq;
using System.Text;

namespace BatchGuard.Protections
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

        private static string GenRandom()
        {
            string name = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("=", "").Replace("+", "");
            name = new string(name.Where(char.IsLetter).ToArray());
            name = name.Substring(0, 4);
            return name;
        }

        public static string GenVars(Random rng)
        {
            lsetname = GenRandom();
            ulsetname = GenRandom();
            numsetname = GenRandom();

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
                        varcode.AppendLine($"%public:~4,1%%public:~5,1%%os:~9,1% {lsetname}={letterset}");
                        break;
                    case 2:
                        varcode.AppendLine($"%public:~4,1%%public:~5,1%%os:~9,1% {ulsetname}={upletterset}");
                        break;
                    case 3:
                        varcode.AppendLine($"%public:~4,1%%public:~5,1%%os:~9,1% {numsetname}={numberset}");
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
                if (invar && c == ' ') invar = false;
                if (c == '\n' || c == '\r') invar = false;
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
