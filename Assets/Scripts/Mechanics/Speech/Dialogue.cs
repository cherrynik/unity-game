using UnityEngine;
using Team.UI;

namespace Team.Mechanics.Speech
{
    public class Dialogue : Menu
    {
        [SerializeField] private DialogueSettings _settings;

        public override void Open()
        {
            base.Open();

            _settings.StartDialogue();
        }
    }
}