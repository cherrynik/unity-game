using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue Node", menuName = "Dialogue System/Dialogue Node")]
public class DialogueNodeSettings : ScriptableObject
{
    [SerializeField] private CharacterSettings _character;
    [SerializeField] private string _text;
}