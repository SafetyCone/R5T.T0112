using System;

using R5T.T0112;

using Instances = R5T.T0112.X001.Instances;


namespace System
{
    public static class ISolutionNameOperatorExtensions
    {
        public static string AppendToken(this ISolutionNameOperator _,
            string solutionNameStem,
            string solutionNameToken)
        {
            var output = $"{solutionNameStem}{Instances.SolutionName.TokenSeparator()}{solutionNameToken}";
            return output;
        }
    }
}
