using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Team.SO.Creature
{
    [CreateAssetMenu(fileName = "NPC", menuName = "Dialogue System/Character")]
    class NonPlayableCharacterSettings : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private GameObject _prefab;
        [SerializeField] private List<string> _scenario = new List<string>(3);
    }
}