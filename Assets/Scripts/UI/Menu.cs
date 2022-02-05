using UnityEngine;
using UnityEngine.InputSystem;

using Team.System;
using Team.Mechanics.Interact;

namespace Team.UI
{
    /// <summary>
    /// Игровые меню, где требуется взаимодействие с экраном.
    /// </summary>
    public abstract class Menu : Interactable {
        [SerializeField] protected GameObject _gameManagerObject;
        [SerializeField] protected GameManager _gameManager;
        [SerializeField] protected PlayerInput _playerInput;

        protected virtual void Awake()
        {
            _gameManagerObject = GameObject.FindWithTag("GameManager");

            _gameManager = _gameManagerObject.GetComponent<GameManager>();
            _playerInput = _gameManagerObject.GetComponent<PlayerInput>();
        }

        public virtual void Open()
        {
            _gameManagerObject = GameObject.FindWithTag("GameManager");

            _gameManager = _gameManagerObject.GetComponent<GameManager>();
            _playerInput = _gameManagerObject.GetComponent<PlayerInput>();

            _gameManager.State = State.Menu;
        }

        public virtual void Close()
        {
            _gameManager.State = State.InGame;
        }
    }
}