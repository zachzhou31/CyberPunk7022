using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private string _walkState;
    [SerializeField] private string _idleState;
    [SerializeField] private string _attackState;

    public void Move(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        if (direction == Vector2.zero)
            _animator.Play(_idleState);
        else
            _animator.Play(_walkState);

        if(direction.x > 0)
        {
            _spriteRenderer.flipX = false;
        }else if(direction.x < 0)
        {
            _spriteRenderer.flipX = true;
        }
    }

    public void Attack()
    {
        //_animator.Play(_attackState);
    }
}
