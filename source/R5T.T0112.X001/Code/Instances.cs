using System;


namespace R5T.T0112.X001
{
    public static class Instances
    {
        public static IProjectNameTokenSeparator ProjectNameTokenSeparator { get; } = T0112.ProjectNameTokenSeparator.Instance;
        public static ISolutionName SolutionName { get; } = T0112.SolutionName.Instance;
    }
}
