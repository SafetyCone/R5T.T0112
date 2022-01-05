using System;

using R5T.T0112;
using R5T.T0112.X001;


namespace System
{
    public static class ISolutionNameExtensions
    {
        public static string DoNotOverride(this ISolutionName _)
        {
            return SolutionNames.DoNotOverride;
        }

        public static bool IsOverridden(this ISolutionName _,
            string solutionName)
        {
            var doNotOverrideValue = _.DoNotOverride();

            var output = !(doNotOverrideValue == solutionName);
            return output;
        }

        public static string TokenSeparator(this ISolutionName _)
        {
            return Strings.Period;
        }
    }
}