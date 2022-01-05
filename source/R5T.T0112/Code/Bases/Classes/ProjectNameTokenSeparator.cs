using System;


namespace R5T.T0112
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ProjectNameTokenSeparator : IProjectNameTokenSeparator
    {
        #region Static
        
        public static ProjectNameTokenSeparator Instance { get; } = new();

        #endregion
    }
}