using UnityEngine;
using UnityEngine.InputSystem;

class Interaction : MonoBehaviour
{
    [SerializeField, ReadOnly] private Interactable target;

    private bool canInteract = true;

    public Interactable Target
    {
        get { return target; }
        set { target = value; }
    }

    private void OnInteract()
    {
        if (!canInteract)
        {
            return;
        }

        if (target.IsAccessible)
        {
            target.Interact();

            // TODO Limitation:
            //
            // A little delay,
            // Where canInteract = false
            // Then canInteract = true;
        }
    }
}