using System;


namespace R5T.T0112
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ProjectNameOperator : IProjectNameOperator
    {
        #region Static
        
        public static ProjectNameOperator Instance { get; } = new();

        #endregion
    }
}