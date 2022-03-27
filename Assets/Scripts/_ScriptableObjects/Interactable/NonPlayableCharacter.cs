using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Team.SO.Interact
{
    /// <summary>
    /// 
    /// </summary>
    [CreateAssetMenu(fileName = "NPC", menuName = "Dialogue System/Character")]
    public class NonPlayableCharacter : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private GameObject _prefab;
        [SerializeField] private List<string> _scenario = new List<string>(3);
    }
}