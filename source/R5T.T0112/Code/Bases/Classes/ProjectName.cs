using System;


namespace R5T.T0112
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ProjectName : IProjectName
    {
        #region Static
        
        public static ProjectName Instance { get; } = new();

        #endregion
    }
}