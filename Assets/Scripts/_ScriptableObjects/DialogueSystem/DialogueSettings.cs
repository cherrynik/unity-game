using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "Dialogue System/Dialogue")]
public class DialogueSettings : ScriptableObject
{
    [SerializeField] private bool _isReplayable;
    [SerializeField] private List<DataDialogueNodeSettings> _dialogueNodes;
    public int _nodeIndex = 0;
    public void StartDialogue()
    {
        PlayNode();
    }

    public void FinishDialogue()
    {}

    public void PlayNode()
    {
        if (_nodeIndex >= _dialogueNodes.Count)
        {
            _nodeIndex = 0;
            return;
        }

        _dialogueNodes[_nodeIndex].Play();
        ++_nodeIndex;

        // if (dialogueNode.HasChoices)
        // {
        // }

        // foreach node in _dialogueNodes
        // play node
        // but if node has choice
        // wait for choice and
        // play then the next node or another dialogue
    }
}