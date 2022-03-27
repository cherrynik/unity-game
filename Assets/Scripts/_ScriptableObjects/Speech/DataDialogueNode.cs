using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Team.SO.Speech
{
    /// <summary>
    /// 
    /// </summary>
    // [CreateAssetMenu(fileName = "Dialogue Node", menuName = "Dialogue System/Dialogue Node")]
    [global::System.Serializable]
    public class DataDialogueNode
    {
        [SerializeField] private Character _character;
        [SerializeField, Multiline(5)] private string _text;
        [SerializeField] private bool _hasChoices;

        [Header("If Has Choices")]
        [SerializeField] private List<DataDialogueNodeChoice> _choices;

        public string Text => _text;
        public bool HasChoices => _hasChoices;
        public List<DataDialogueNodeChoice> Choices => _choices;

        public void Play()
        {
            Debug.Log(_text);
        }
    }
}