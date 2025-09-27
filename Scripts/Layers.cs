using UnityEngine;

namespace MGeLabs.Core
{
    /// <summary>
    /// A static utility class for receiving Unity layers.
    /// </summary>
    public static class Layers
    {
        public static int DefaultLayer = LayerMask.NameToLayer("Default");
        public static int GroundLayer = LayerMask.NameToLayer("Ground");
        public static int IgnoreRaycastLayer = LayerMask.NameToLayer("Ignore Raycast");
        public static int CharacterLayer = LayerMask.NameToLayer("Character");
        public static int InteractableLayer = LayerMask.NameToLayer("Interactable");

        /// <summary>
        /// Converts an array of layer indices into a LayerMask.
        /// </summary>
        /// <param name="layers">An array of layer indices.</param>
        /// <returns>A LayerMask representing the combined layers.</returns>
        public static LayerMask ToMask(params int[] layers)
        {
            int mask = 0;
            foreach (int l in layers)
                mask |= (1 << l);
            return mask;
        }
    }
}