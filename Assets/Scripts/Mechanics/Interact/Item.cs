using Team.Mechanics.Storage;
using UnityEngine;

namespace Team.Mechanics.Interact
{
    /// <summary>
    /// 
    /// </summary>
    public class Item : Interactable
    {
        [SerializeField] private SO.Interact.Item _settings;
        public SO.Interact.Item Settings => _settings;

        /// <summary>
        /// 
        /// </summary>
        public void Interact(Inventory inventory)
        {
            if (inventory.AddItem(this))
            {
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Inventory is full");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static public bool Compare(Item itemA, Item itemB) => itemA.Settings == itemB.Settings;
    }

}