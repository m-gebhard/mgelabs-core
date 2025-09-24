using System;
using UnityEngine;

namespace MGeLabs.Core
{
    /// <summary>
    /// Defines an interface for receiving player input.
    /// </summary>
    public interface IInputManager
    {
        #region Properties

        public bool IsGamepad { get; }

        public Vector2 Move { get; }
        public Vector2 Look { get; }

        public IInputButton Interact { get; }
        public IInputButton Confirm { get; }
        public IInputButton Abort { get; }
        public IInputButton Pause { get; }
        public IInputButton Flashlight { get; }

        public IInputButton Selection1 { get; }
        public IInputButton Selection2 { get; }
        public IInputButton Selection3 { get; }
        public IInputButton Selection4 { get; }
        public IInputButton Selection5 { get; }
        public IInputButton Selection6 { get; }

        #endregion

        public event Action<string> OnControlsChanged;

        public void ResetInputs();
    }
}