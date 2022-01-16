using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private Interaction interaction;
    [SerializeField, ReadOnly] private bool isAccessible = false;

    public bool IsAccessible {
        get => isAccessible;
    }

    private void Awake()
    {
        interaction = FindObjectOfType<Interaction>();
    }

    private void SwitchAccessIfPlayer(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isAccessible = !isAccessible;
        }

        if (isAccessible)
        {
            interaction.Target = this;
        }
        else
        {
            if (interaction.Target == this)
            {
                interaction.Target = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SwitchAccessIfPlayer(other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        SwitchAccessIfPlayer(other);
    }

}
