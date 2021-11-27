using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;

namespace TaskTest
{
    public class SimpleTask : Microsoft.Build.Utilities.Task
    {
        public override bool Execute()
        {
            if (Environment.Is64BitProcess)
            {
                Console.WriteLine("64-bit process");
                base.Log.LogMessageFromText($"64-bit process", MessageImportance.High);
            }
            else
            {
                Console.WriteLine("32-bit process");
                base.Log.LogMessageFromText($"32-bit process", MessageImportance.High);
            }

            return true;
        }
    }
}
