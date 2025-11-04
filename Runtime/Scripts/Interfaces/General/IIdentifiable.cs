namespace MGeLabs.Core
{
    /// <summary>
    /// Represents an interface for objects that have a unique identifier.
    /// </summary>
    public interface IIdentifiable
    {
        /// <summary>
        /// Gets the unique identifier for the object.
        /// </summary>
        public string Identifier { get; }
    }
}