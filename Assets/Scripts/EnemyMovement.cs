using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _moveSpeed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        var playerPosition = PlayerManager.PlayerPosition;
        var position = (Vector2)transform.position;
        var direction = playerPosition - position;
        direction.Normalize();
        var targetPosition = position + direction;

        _rigidbody.DOMove(targetPosition, _moveSpeed).SetSpeedBased();
    }
}
