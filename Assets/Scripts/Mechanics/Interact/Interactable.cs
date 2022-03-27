using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Team.Mechanics.Interact
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Interactable : MonoBehaviour
    {
        [SerializeField, ReadOnly] private InteractManager _interactManager;
        [SerializeField, ReadOnly] private bool _isAccessible = false;

        public bool IsAccessible => _isAccessible;

        /// <summary>
        /// 
        /// </summary>
        void SwitchAccessIfPlayer(Collider2D other)
        {
            GameObject target = other.gameObject;
            if (target.CompareTag("Player"))
            {
                _interactManager ??= target.GetComponent<InteractManager>();
                _isAccessible = !_isAccessible;
            }

            if (_isAccessible)
            {
                OnAccess();
            }
            else
            {
                OnInaccess();
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            SwitchAccessIfPlayer(other);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            SwitchAccessIfPlayer(other);
        }

        // TODO: Notify all events into event manager
        /// <summary>
        /// 
        /// </summary>
        private void OnAccess()
        {
            _interactManager.Targets.Add(this);
        }

        /// <summary>
        /// 
        /// </summary>
        private void OnInaccess()
        {
            if (_interactManager.Targets.Contains(this))
            {
                _interactManager.Targets.Remove(this);
            }
        }

    }
}