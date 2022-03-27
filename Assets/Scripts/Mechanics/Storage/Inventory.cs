using System.Collections.Generic;
using Team.Mechanics.Interact;
using UnityEngine;

namespace Team.Mechanics.Storage
{
    /// <summary>
    /// 
    /// </summary>
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private List<Slot> _slots = new List<Slot>();
        [SerializeField, Range(1, 10)] private int _capacity = 1;
        [SerializeField, ReadOnly] private int _size = 0;

        public List<Slot> Slots => _slots;
        public int Capacity => _capacity;
        public int Size => _size;

        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            _slots = new List<Slot>(_capacity);
            for (int i = 0; i < _capacity; i++)
            {
                _slots.Add(new Slot());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsFull() => _size == _capacity;

        /// <summary>
        /// 
        /// </summary>
        public bool IsEmpty() => _size == 0;

    #nullable enable
        /// <summary>
        /// 
        /// </summary>
        public Slot? GetEmptySlot()
        {
            if (IsFull())
            {
                return null;
            }

            foreach (Slot slot in _slots)
            {
                if (slot.IsEmpty())
                {
                    return slot;
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        public Slot? GetAvailableSlot(Item itemToFind)
        {
            if (IsEmpty())
            {
                return _slots[0];
            }

            Slot? emptySlot = null;
            int activeSlotsChecked = 0;

            foreach (Slot slot in _slots)
            {
                bool isEmpty = slot.IsEmpty();

                emptySlot ??= isEmpty ? slot : null;

                if (activeSlotsChecked == _size && emptySlot != null)
                {
                    return emptySlot;
                } // First free slot if it's unique item

                if (!isEmpty)
                {
                    bool areSame = Item.Compare(slot.Item, itemToFind) &&
                        slot.ItemCount < itemToFind.Settings.MaxCount;

                    if (areSame)
                    {
                        return slot;
                    }
                    ++activeSlotsChecked;
                } // Looking for the same item
            }

            return emptySlot;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool AddItem(Item item)
        {
            Slot? availableSlot;

            if (item.Settings.IsStackable)
            {
                availableSlot = GetAvailableSlot(item);
                if (availableSlot is null) // New unique item in full inventory
                {
                    return false;
                }

                if (availableSlot.IsEmpty())
                {
                    availableSlot.Item = item;
                    ++_size;
                }
                ++availableSlot.ItemCount;

                return true;
            }

            availableSlot = GetEmptySlot();
            if (availableSlot is null)
            {
                return false;
            }

            availableSlot.Item = item;
            ++_size;
            ++availableSlot.ItemCount;

            return true;
        }
    #nullable disable
    }
}