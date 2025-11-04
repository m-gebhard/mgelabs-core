namespace MGeLabs.Core
{
    /// <summary>
    /// Represents an interface for interactable objects that can be focused on by an interactor.
    /// </summary>
    public interface IFocusableInteractable
    {
        /// <summary>
        /// Called when the interactor focuses on the interactable object.
        /// </summary>
        /// <param name="interactor">The interactor focusing on the object.</param>
        public void OnFocus(IInteractor interactor);

        /// <summary>
        /// Called when the interactor loses focus on the interactable object.
        /// </summary>
        /// <param name="interactor">The interactor that lost focus on the object.</param>
        public void OnFocusLost(IInteractor interactor);
    }
}