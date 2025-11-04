namespace MGeLabs.Core
{
    /// <summary>
    /// Represents an interface for objects that can be reset to their initial state.
    /// </summary>
    public interface IResetable
    {
        /// <summary>
        /// Initiates the reset process for the implementing object.
        /// </summary>
        public void InitiateReset();
    }
}