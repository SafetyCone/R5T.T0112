using System;

using R5T.T0112;

using Instances = R5T.T0112.X002.Instances;


namespace System
{
    public static class IProjectNameOperatorExtensions
    {
        /// <summary>
        /// Gets a code-identifier rules compliant project name, i.e. a project name that could be used in C# code.
        /// </summary>
        public static string GetIdentifierCompliantProjectName(this IProjectNameOperator _,
            string projectName)
        {
            var output = Instances.Syntax.GetIdentifierCompliantName(projectName);
            return output;
        }

        /// <summary>
        /// Gets a name that could be used as a method name from a project name.
        /// </summary>
        public static string GetMethodNameForProjectName(this IProjectNameOperator _,
            string projectName)
        {
            var output = _.GetIdentifierCompliantProjectName(projectName);
            return output;
        }

        /// <summary>
        /// Replaces all code-special characters in a project name with underscore.
        /// </summary>
        public static string GetUnderscoredProjectName(this IProjectNameOperator _,
            string projectName)
        {
            var output = _.GetIdentifierCompliantProjectName(projectName);
            return output;
        }
    }
}