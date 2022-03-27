using UnityEngine;

namespace Team.SO.Speech
{
    /// <summary>
    /// 
    /// </summary>
    [CreateAssetMenu(fileName = "Character", menuName = "Dialogue System/Character")]
    class Character : ScriptableObject
    {
        [SerializeField] private Sprite _portrait;
        [SerializeField] private string _name;
    }
}