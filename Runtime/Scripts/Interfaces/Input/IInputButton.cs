using System;

namespace MGeLabs.Core
{
    /// <summary>
    /// Represents an input button interface that provides an event for when the button is pressed.
    /// </summary>
    public interface IInputButton
    {
        /// <summary>
        /// Whether the button is currently pressed.
        /// </summary>
        public bool IsPressed { get; }

        /// <summary>
        /// Event triggered when the input button is pressed.
        /// </summary>
        public event Action OnPressed;

        /// <summary>
        /// Updates the button's value.
        /// </summary>
        public void UpdateValue(bool value);
    }
}