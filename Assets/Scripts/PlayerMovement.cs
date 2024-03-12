using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private Rigidbody2D _rigidbody;
    private Vector2 _inputDirection;
    [SerializeField] private float _moveSpeed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    public void Move(InputAction.CallbackContext context)
    {
        _inputDirection = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        var position = (Vector2)transform.position;
        var targetPosition = position + _inputDirection;

        if (position == targetPosition) return;

        _rigidbody.DOMove(targetPosition, _moveSpeed).SetSpeedBased();        
    }
}
