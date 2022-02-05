using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Dialogue Node", menuName = "Dialogue System/Dialogue Node")]
public class DialogueNodeSettings : ScriptableObject
{
    [SerializeField] private CharacterSettings _character;
    [SerializeField, Multiline(5)] private string _text;
    [SerializeField] private bool _hasChoices;

    [Header("If Has Choices")]
    [SerializeField] private List<DataDialogueNodeChoiceSettings> _choices;

    public string Text => _text;
    public bool HasChoices => _hasChoices;
    public List<DataDialogueNodeChoiceSettings> Choices => _choices;
} 