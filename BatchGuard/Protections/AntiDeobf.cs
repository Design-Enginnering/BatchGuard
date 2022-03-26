using System;

namespace BatchGuard.Protections
{
    public class AntiDeobf
    {
        public static string GenCode(string input)
        {
            string[] lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i] + " >nul";
            }
            return string.Join(Environment.NewLine, lines);
        }
    }
}
