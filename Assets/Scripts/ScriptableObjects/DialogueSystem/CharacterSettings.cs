using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Dialogue System/Character")]
class CharacterSettings : ScriptableObject
{
    [SerializeField] private Sprite _portrait;
    [SerializeField] private string _name;
}