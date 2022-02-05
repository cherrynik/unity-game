using UnityEngine;

namespace Team.Mechanics.Storage
{
    [global::System.Serializable]
    public class Slot // TODO: In struct
    {
        public Item Item
        {
            get => _item;
            set => _item = value;
        }
        public int ItemCount
        {
            get => _itemCount;
            set => _itemCount = value;
        }

        [SerializeField] private Item _item;
        [SerializeField] private int _itemCount;

        public bool IsEmpty() => _item is null;
    }
}