using UnityEngine;
using UnityEngine.Events;

namespace Team.SO.Speech
{
    /// <summary>
    /// 
    /// </summary>
    // [CreateAssetMenu(fileName = "Dialogue Node Choice", menuName = "Dialogue System/Dialogue Node Choice")]
    [global::System.Serializable]
    public class DataDialogueNodeChoice
    {
        [SerializeField] private string _previewText;
        [SerializeField] private string _nodeText;
        [Space]
        [SerializeField] private bool _branchesAway;

        [Header("If Branches Away")]
        [SerializeField] public DialogueNode _branchToNode;
    }
}