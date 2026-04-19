using System;
using UnityEngine;

namespace MGeLabs.Core
{
    /// <summary>
    /// Represents an interactable object that can handle exit interactions.
    /// </summary>
    public interface IExitableInteractable : IInteractable
    {
        /// <summary>
        /// Gets the GameObject of the camera of the interactable.
        /// When interaction starts, the GameObject will be activated, and when interaction ends, it will be deactivated.
        /// </summary>
        public GameObject Camera => null;

        /// <summary>
        /// Indicates whether the interactor's enableable state can be toggled.
        /// </summary>
        /// <remarks>
        /// This property determines if the interactor's enableable state can be modified.
        /// Assuming the interactor has an <c>IEnableable</c> component which controls movement,
        /// the movement could be disabled while interacting with this object using this flag.
        /// By default, it returns <c>false</c>.
        /// </remarks>
        public bool CanToggleInteractorEnableable => false;

        /// <summary>
        /// Can be called to force exit the interactable object.
        /// </summary>
        public event Action OnForceExit;

        /// <summary>
        /// Called when an interactor exits the interactable object.
        /// </summary>
        /// <param name="interactor">The interactor that is exiting.</param>
        public void OnExit(IInteractor interactor);
    }
}