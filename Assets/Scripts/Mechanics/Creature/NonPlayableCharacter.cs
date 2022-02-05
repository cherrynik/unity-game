using UnityEngine;

using Team.Mechanics.Speech;
using Team.Mechanics.Interact;
using Team.SO.Creature;

namespace Team.Mechanics.Creature
{
    public class NonPlayableCharacter : Interactable
    {
        [SerializeField] private NonPlayableCharacterSettings _settings;
        [Space]
        [SerializeField] private Dialogue _tempDialogue;

        public void Interact()
        {
            _tempDialogue.Open();
        }
    }
}