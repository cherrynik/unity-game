using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private Collider2D activeZone;
    [SerializeField] private Interaction interaction;

    [SerializeField, ReadOnly] private bool isAccessible = false;

    public bool IsAccessible {
        get { return isAccessible; }
    }

    public void Interact()
    {
        Debug.Log("Interaction!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            interaction.Target = this;

            isAccessible = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isAccessible = false;
        }
    }

}
