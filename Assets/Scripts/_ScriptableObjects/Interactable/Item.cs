using UnityEngine;

namespace Team.SO.Interact
{
    /// <summary>
    /// 
    /// </summary>
    [CreateAssetMenu(fileName = "Item", menuName = "Interaction System/Item")]
    public class Item : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private Texture2D _sprite;
        [SerializeField] private GameObject _prefab;
        [SerializeField, Range(1, 99)] private int _maxCount = 1;

        public string Name => _name;
        public GameObject Prefab => _prefab;
        public int MaxCount => _maxCount;
        public bool IsStackable => _maxCount > 1;
    }
}