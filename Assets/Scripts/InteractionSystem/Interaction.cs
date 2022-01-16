using UnityEngine;
using UnityEngine.InputSystem;

class Interaction : MonoBehaviour
{
    [SerializeField, ReadOnly] private Interactable _target;
    [SerializeField] private Inventory _inventory;

    public Interactable Target
    {
        get { return _target; }
        set { _target = value; }
    }

    private void Awake()
    {
        _inventory ??= GetComponent<Inventory>();
    }

    private void OnInteract()
    {
        if (_target == null)
        {
            return;
        }

        if (_target.IsAccessible)
        {
            switch (_target)
            {
                case Item item:
                {
                    item.Interact(_inventory);
                    break;
                }
                default:
                {
                    break;
                }
            }

            // TODO Limitation:
            //
            // A little delay,
            // Where canInteract = false
            // Then canInteract = true;
        }
    }
}