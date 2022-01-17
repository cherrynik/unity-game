using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

class Interaction : MonoBehaviour
{
    [SerializeField, ReadOnly] private List<Interactable> _targets;
    [SerializeField] private Inventory _inventory;

    public List<Interactable> Targets
    {
        get => _targets;
        set => _targets = value;
    }

    private void Awake()
    {
        _inventory ??= GetComponent<Inventory>();
    }

    private void OnInteract()
    {
        if (_targets.Count == 0)
        {
            return;
        }

        Interactable lastElement = _targets[_targets.Count - 1];
        switch (lastElement)
        {
            case Item item:
            {
                item.Interact(_inventory);
                _targets.Remove(lastElement);
                break;
            }
            default:
            {
                break;
            }
        }
    }
}