using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Team.Mechanics.Interact;
using Team.SO.Interact;

namespace Team.Mechanics.Storage
{
    public class Item : Interactable
    {
        [SerializeField] private ItemSettings _settings;
        public ItemSettings Settings => _settings;

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

        static public bool Compare(Item itemA, Item itemB)
        {
            // return itemA.Settings.Name == itemB.Settings.Name;
            return itemA.Settings == itemB.Settings;
        }
    }

}