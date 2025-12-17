#if UNITY_EDITOR

namespace MGeLabs.Core
{
    /// <summary>
    /// Provides an interface for managing character creator context data.
    /// Allows setting and retrieving data associated with character creator modules.
    /// </summary>
    public interface ICharacterCreatorContext
    {
        /// <summary>
        /// Sets data for a specific character creator module.
        /// </summary>
        /// <typeparam name="T">The type of the character creator module.</typeparam>
        /// <param name="value">The data to set for the module.</param>
        public void SetData<T>(object value) where T : ICharacterCreatorModule;

        /// <summary>
        /// Attempts to retrieve data for a specific character creator module.
        /// </summary>
        /// <typeparam name="T">The type of the character creator module.</typeparam>
        /// <typeparam name="TValue">The type of the data to retrieve.</typeparam>
        /// <param name="value">The retrieved data if the operation is successful.</param>
        /// <returns>True if the data was successfully retrieved; otherwise, false.</returns>
        public bool TryGetData<T, TValue>(out TValue value) where T : ICharacterCreatorModule;
    }
}
#endif