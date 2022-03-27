using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

using Team.Mechanics.Storage;
using Team.Mechanics.Creature;

namespace Team.Mechanics.Interact
{
    /// <summary>
    /// 
    /// </summary>
    class InteractManager : MonoBehaviour
    {
        [SerializeField, ReadOnly] private List<Interactable> _targets;
        [SerializeField] private Inventory _inventory;

        public List<Interactable> Targets
        {
            get => _targets;
            set => _targets = value;
        }

        private void Awake()
        {
            _inventory ??= GetComponent<Inventory>();
        }

        /// <summary>
        /// 
        /// </summary>
        private void OnInteract()
        {
            if (_targets.Count == 0)
            {
                return;
            }

            Handle();
        }

        private void Handle()
        {
            Interactable lastElement = _targets[_targets.Count - 1];
            switch (lastElement)
            {
                case Item item:
                {
                    item.Interact(_inventory);
                    _targets.Remove(lastElement);
                    break;
                }
                case NonPlayableCharacter npc:
                {
                    npc.Interact();
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
}