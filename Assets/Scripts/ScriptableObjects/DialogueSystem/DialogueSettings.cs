using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "Dialogue System/Dialogue")]
public class DialogueSettings : ScriptableObject
{
    [SerializeField] private List<DialogueNodeSettings> _dialogueNodes =
        new List<DialogueNodeSettings>();

    public List<DialogueNodeSettings> DialogueNodes => _dialogueNodes;
}