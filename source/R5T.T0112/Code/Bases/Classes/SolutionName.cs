using System;


namespace R5T.T0112
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SolutionName : ISolutionName
    {
        #region Static
        
        public static SolutionName Instance { get; } = new();

        #endregion
    }
}