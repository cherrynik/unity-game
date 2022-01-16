using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Slot> _slots = new List<Slot>();
    [SerializeField, Range(1, 10)] private int _capacity = 1;
    [SerializeField, ReadOnly] private int _size = 0;

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

    public bool IsFull() => _size == _capacity;

    public bool IsEmpty() => _size == 0;

#nullable enable
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

            if (!isEmpty)
            {
                bool areSame = Item.Compare(slot.Item, itemToFind) &&
                    slot.ItemCount < itemToFind.Settings.MaxCount;

                if (areSame)
                {
                    return slot;
                }
                ++activeSlotsChecked;
            }

            if (activeSlotsChecked == _size)
            {
                return emptySlot;
            }
        }

        return emptySlot;
    }

    public bool AddItem(Item item)
    {
        Slot? availableSlot;

        if (item.Settings.IsStackable)
        {
            availableSlot = GetAvailableSlot(item);
            if (availableSlot is null)
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