using UnityEngine;

namespace MGeLabs.Core
{
    /// <summary>
    /// Represents an interactor in the Unity scene.
    /// Provides functionality for interaction handling and transform access.
    /// </summary>
    public interface IInteractor
    {
        /// <summary>
        /// Gets the transform of the interactor.
        /// </summary>
        public Transform Transform { get; }

        /// <summary>
        /// Called when an interaction starts.
        /// </summary>
        public void OnInteractionStart();
    }
}