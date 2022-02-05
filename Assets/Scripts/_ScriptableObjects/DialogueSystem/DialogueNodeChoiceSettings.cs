using System;
using UnityEngine;
using UnityEngine.Events;

// [CreateAssetMenu(fileName = "Dialogue Node Choice", menuName = "Dialogue System/Dialogue Node Choice")]
[Serializable]
public class DataDialogueNodeChoiceSettings
{
    [SerializeField] private string _previewText;
    [SerializeField] private string _nodeText;
    [Space]
    [SerializeField] private bool _branchesAway;

    [Header("If Branches Away")]
    [SerializeField] public DialogueNodeSettings _branchToNode;
}