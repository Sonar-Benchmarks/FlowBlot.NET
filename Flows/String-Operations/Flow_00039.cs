﻿namespace FlowBlot.Flows
{
    public class Flow_00039
    {
        public const string ID = "00039"; 
        public const string Description = "A StringBuilder taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            var sb = new System.Text.StringBuilder();

            foreach (char c in input)
            {
                if (c > 69)
                {
                    sb.Append(c);
                }
            }

            System.Diagnostics.Process.Start(sb.ToString());
        }

    }
}
