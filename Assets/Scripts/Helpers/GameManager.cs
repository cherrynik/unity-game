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
    public class GameManager : Singletone<GameManager>
    {

        [SerializeField] private State _state;
        [SerializeField] private PlayerInput _inputSystem;

        public State State { get => _state; set => _state = value; }

        protected override void Awake()
        {
            base.Awake();

            _inputSystem ??= GetComponent<PlayerInput>();
        }

        /// <summary>
        /// Событие, обычно вызываемое Input System'ой автоматически,
        /// при наличии PlayerInput компонента на GameObject'е.
        /// </summary>
        public bool OnSubmit() => _state == State.Menu;
    }
}