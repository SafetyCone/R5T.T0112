using System;


namespace R5T.T0112
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ProjectNameAffix : IProjectNameAffix
    {
        #region Static
        
        public static ProjectNameAffix Instance { get; } = new();

        #endregion
    }
}