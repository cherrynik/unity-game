using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
class InteractableObject : ScriptableObject
{
    [SerializeField] private string _name = "John Smith";
    [SerializeField] private GameObject _prefab;
    [SerializeField] private List<string> _scenario = new List<string>(3);
}