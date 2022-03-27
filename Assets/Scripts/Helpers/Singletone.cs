using System;
using UnityEngine;

namespace Team.System
{
    public class Singletone<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;
        
        public static T Instance => _instance;

        protected virtual void Awake()
        {
            if (_instance != null)
            {
                Debug.LogError(
                    $"There is already existing: Singletone<{_instance}>." +
                    "\n" +
                    $"Deleting: Singletone<{this}>.");

                Destroy(this);
            } else
            {
                _instance = GetComponent<T>();
                DontDestroyOnLoad(gameObject);
            }
        }
    }
}