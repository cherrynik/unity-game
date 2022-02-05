using UnityEngine;

namespace Team.Mechanics.Speech
{
    public class DialogueNode : MonoBehaviour
    {
        [SerializeField] private DialogueNodeSettings _settings;
        public DialogueNodeSettings Settings => _settings;
    }
}