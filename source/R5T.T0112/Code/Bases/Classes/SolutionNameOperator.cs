using System;


namespace R5T.T0112
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SolutionNameOperator : ISolutionNameOperator
    {
        #region Static
        
        public static SolutionNameOperator Instance { get; } = new();

        #endregion
    }
}