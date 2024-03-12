using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicMissileMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D _rigidbody;
    [SerializeField]private float _moveSpeed;

    private Vector2 _direction;
    private GameObject LocateEnemy()
    {
        var results = new Collider2D[5];
        Physics2D.OverlapCircleNonAlloc(transform.position, 10, results);

        foreach(var result in results)
        {
            if (result != null && result.CompareTag("Enemy"))
            {
                return result.gameObject;
            }
        }

        return null;
    }

    private Vector2 MoveDirection(Transform target)
    {
        var direction = new Vector2(1, 0);

        if(target != null)
        {
            direction = (Vector2)(target.position - transform.position);
            direction.Normalize();
        }

        return direction;
    }

    private void Awake()
    {
        var enemy = LocateEnemy();
        if(enemy ==  null)
            _direction = MoveDirection(null);
        else
            _direction = MoveDirection(enemy.transform);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, _direction);
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var targetPosition = (Vector2)transform.position + _direction;
        _rigidbody.DOMove(targetPosition, _moveSpeed).SetSpeedBased();
    }
}
