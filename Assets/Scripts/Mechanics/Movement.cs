using UnityEngine;
using UnityEngine.InputSystem;

namespace Team.Mechanics
{
    /// <summary>
    /// Передвижение существа
    /// </summary>
    public class Movement : MonoBehaviour
    {
        [SerializeField, Range(1, 10)] private int _speed = 5;
        [SerializeField] private Rigidbody2D _rigidbody;
        private Vector2 _input;

        private void FixedUpdate()
        {
            Vector2 newPosition = _rigidbody.position + (_input * _speed * Time.fixedDeltaTime);
            _rigidbody.MovePosition(newPosition);
        }

        /// <summary>
        /// Событие, обычно вызываемое Input System'ой автоматически,
        /// при наличии компонента PlayerInput на GameObject'е.
        /// </summary>
        /// <param name="inputValue">Векторное направление на следующую позицию.</param>
        public void OnMove(InputValue inputValue)
        {
            _input = inputValue.Get<Vector2>();
        }
    }
}