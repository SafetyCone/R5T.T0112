using System;

using R5T.T0112;
using R5T.T0112.X001;


namespace System
{
    public static class IProjectNameTokenSeparatorExtensions
    {
        /// <summary>
        /// Period.
        /// </summary>
        public static string Default(this IProjectNameTokenSeparator _)
        {
            return ProjectNameTokenSeparators.Default;
        }
    }
}
