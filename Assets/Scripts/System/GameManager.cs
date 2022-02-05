using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Team.System
{
    [Serializable]
    public enum State
    {
        InGame,
        Menu
    }

    /// <summary>
    /// Управляет игровым потоком по типу:
    /// игровые состояния, прогресс и т.д.
    /// </summary>
    public class GameManager : MonoBehaviour
    {

        [SerializeField] private State _state;
        [SerializeField] private PlayerInput _inputSystem;

        [Header("Player's Fields")]
        [SerializeField] private GameObject _player;

        public State State { get => _state; set => _state = value; }
        public static event Action NextNode;

        private void Awake()
        {
            _inputSystem ??= GetComponent<PlayerInput>();
        }

        /// <summary>
        /// Событие, обычно вызываемое Input System'ой автоматически,
        /// при наличии PlayerInput компонента на GameObject'е.
        /// </summary>
        public bool OnSubmit()
        {
            if (_state == State.Menu)
            {
                return true;
            }
            return false;
        }
    }
}