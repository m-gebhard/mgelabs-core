namespace MGeLabs.Core
{
    /// <summary>
    /// Represents an interface for objects that can be rebuilt.
    /// </summary>
    public interface IRebuildable
    {
        /// <summary>
        /// Rebuilds the object.
        /// </summary>
        public void Rebuild();
    }
}