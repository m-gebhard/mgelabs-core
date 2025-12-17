#if UNITY_EDITOR
using UnityEngine;

namespace MGeLabs.Core
{
    /// <summary>
    /// Interface for character creator modules, defining the structure and behavior of modules used in the character creation process.
    /// </summary>
    public interface ICharacterCreatorModule
    {
        /// <summary>
        /// Gets the name of the module.
        /// </summary>
        public string ModuleName { get; }

        /// <summary>
        /// Gets the display order of the module in the editor. Defaults to 0.
        /// </summary>
        public int DisplayOrder => 0;

        /// <summary>
        /// Gets the display type of the module, determining how it is shown in the editor.
        /// </summary>
        public int DisplayType => 0;

        /// <summary>
        /// Gets the execution order of the module during the character creation process. Defaults to 0.
        /// </summary>
        public int ExecutionOrder => 0;

        /// <summary>
        /// Called when the module is enabled, allowing for initialization logic.
        /// </summary>
        /// <param name="context">The character creator context.</param>
        public void OnEnable(ICharacterCreatorContext context);

        /// <summary>
        /// Called when the module is disabled, allowing for cleanup logic.
        /// </summary>
        /// <param name="context">The character creator context.</param>
        public void OnDisable(ICharacterCreatorContext context);

        /// <summary>
        /// Draws the user interface for the module in the editor.
        /// </summary>
        /// <param name="context">The character creator context.</param>
        /// <param name="spawnedCharacter">The character GameObject being edited.</param>
        public void DrawUI(ICharacterCreatorContext context, GameObject spawnedCharacter);

        /// <summary>
        /// Executes the module's preview instructions, modifying the character for preview purposes.
        /// </summary>
        /// <param name="spawnedCharacter">The character GameObject to modify.</param>
        /// <param name="context">The character creator context.</param>
        /// <returns>The modified character GameObject.</returns>
        public GameObject ExecutePreviewInstructions(GameObject spawnedCharacter, ICharacterCreatorContext context);

        /// <summary>
        /// Rolls back the module's preview instructions, reverting any preview changes.
        /// </summary>
        /// <param name="spawnedCharacter">The character GameObject to revert.</param>
        /// <param name="context">The character creator context.</param>
        /// <returns>The reverted character GameObject.</returns>
        public GameObject RollbackPreviewInstructions(GameObject spawnedCharacter, ICharacterCreatorContext context);

        /// <summary>
        /// Executes the module's final instructions, applying permanent changes to the character.
        /// </summary>
        /// <param name="spawnedCharacter">The character GameObject to modify.</param>
        /// <param name="context">The character creator context.</param>
        /// <returns>The modified character GameObject.</returns>
        public GameObject ExecuteFinalInstructions(GameObject spawnedCharacter, ICharacterCreatorContext context);

        /// <summary>
        /// Rolls back the module's final instructions, reverting any permanent changes.
        /// </summary>
        /// <param name="spawnedCharacter">The character GameObject to revert.</param>
        /// <param name="context">The character creator context.</param>
        /// <returns>The reverted character GameObject.</returns>
        public GameObject RollbackFinalInstructions(GameObject spawnedCharacter, ICharacterCreatorContext context);
    }
}
#endif