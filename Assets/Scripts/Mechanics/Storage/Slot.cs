using Team.Mechanics.Interact;
using UnityEngine;

namespace Team.Mechanics.Storage
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Serializable]
    public class Slot // TODO: In struct
    {
        public Item Item
        {
            get => _item;
            set {
                _itemName = value.Settings.Name;
                _item = value;
            }
        }
        public int ItemCount
        {
            get => _itemCount;
            set => _itemCount = value;
        }

        [SerializeField, ReadOnly] private string _itemName;
        [SerializeField] private int _itemCount;
        private Item _item;

        public bool IsEmpty() => _item is null;
    }
}