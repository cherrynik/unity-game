using UnityEngine;

namespace Team.SO.Interact
{
    [CreateAssetMenu(fileName = "Item", menuName = "Interaction System/Item")]
    public class ItemSettings : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private Texture2D _sprite;
        [SerializeField] private GameObject _prefab;
        [SerializeField] private bool _isStackable;

        [Header("If Stackable")]
        [SerializeField, Range(2, 100)] private int _maxCount = 2;

        public string Name => _name;
        public GameObject Prefab => _prefab;
        public bool IsStackable => _isStackable;
        public int MaxCount => _maxCount;
    }
}