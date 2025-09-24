using UnityEngine;

namespace MGeLabs.Core
{
    /// <summary>
    /// Interface representing an interactable object in the game.
    /// </summary>
    public interface IInteractable
    {
        /// <summary>
        /// Gets the interactable's label.
        /// </summary>
        public string Label { get; }

        /// <summary>
        /// Gets the name of the Input Action whose binding icon will be displayed for this interactable.
        /// </summary>
        public string ActionIconName => "Interact";

        /// <summary>
        /// Gets the interactable's interaction time.
        /// </summary>
        public float InteractionTime { get; }

        /// <summary>
        /// Gets whether the Interactable can be interacted with.
        /// </summary>
        public bool IsInteractable => true;

        /// <summary>
        /// Gets the transform of the interactable object.
        /// </summary>
        public Transform Transform { get; }

        /// <summary>
        /// Gets the transform used for displaying interaction prompts.
        /// </summary>
        public Transform PromptTransform { get; }

        /// <summary>
        /// Called when <see cref="InteractionTime"/> is > 0 and the interaction with the object starts.
        /// Can be implemented to perform animations, transitions etc. for the interaction duration.
        /// </summary>
        /// <param name="interactor">The interactor initiating the interaction.</param>
        public void OnInteractionStart(IInteractor interactor)
        {
        }

        /// <summary>
        /// Called when the interaction with the object is aborted.
        /// Can be implemented to handle cleanup or rollback actions when an interaction is interrupted.
        /// </summary>
        /// <param name="interactor">The interactor aborting the interaction.</param>
        public void OnInteractionAbort(IInteractor interactor)
        {
        }

        /// <summary>
        /// Called when the interactable object is interacted with.
        /// </summary>
        /// <param name="interactor">The interactor performing the interaction.</param>
        /// <returns>Returns true if the interaction was successful, false otherwise.</returns>
        public bool OnInteract(IInteractor interactor);

        /// <summary>
        /// Called when <see cref="InteractionTime"/> is > 0 and the interaction with the object finished.
        /// At this time the execution of OnInteract has finished.
        /// Can be implemented to perform animations, transitions etc. for the interaction end.
        /// </summary>
        /// <param name="interactor">The interactor initiating the interaction.</param>
        public void OnInteractionFinished(IInteractor interactor)
        {
        }
    }
}