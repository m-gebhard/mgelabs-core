namespace MGeLabs.Core
{
    /// <summary>
    /// Represents an interface for objects that can be enabled or disabled.
    /// </summary>
    public interface IEnableable
    {
        /// <summary>
        /// Enables the object, activating its functionality.
        /// </summary>
        public void Enable();

        /// <summary>
        /// Disables the object, deactivating its functionality.
        /// </summary>
        public void Disable();
    }
}