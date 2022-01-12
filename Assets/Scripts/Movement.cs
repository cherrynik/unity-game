using UnityEngine;
using UnityEngine.InputSystem;

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

    private void OnMove(InputValue inputValue)
    {
        _input = inputValue.Get<Vector2>();
    }
}
