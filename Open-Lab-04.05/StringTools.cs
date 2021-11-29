using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string done = "";
            int i = 1;
            foreach (char c in orig)
            {
                while (i <= n)
                {
                    done += c.ToString();
                    i++;
                }
                i = 1;
            }
            return done;
        }
    }
}
