using System;

using R5T.T0112;

using Instances = R5T.T0112.X001.Instances;


namespace System
{
    public static class IProjectNameOperatorExtensions
    {
        public static string GetProjectName(this IProjectNameOperator _,
            string projectNameStem,
            string projectNameAppendix)
        {
            var output = $"{projectNameStem}{Instances.ProjectNameTokenSeparator.Default()}{projectNameAppendix}";
            return output;
        }

        public static string GetDefaultNamespaceNameFromProjectName(this IProjectNameOperator _,
           string projectName)
        {
            // The default namespace name is just the project name.
            var namespaceName = projectName;
            return namespaceName;
        }
    }
}
