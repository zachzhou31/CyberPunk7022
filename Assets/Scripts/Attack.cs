using System.Collections;
using System.Collections.Generic;
using Timers;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    [SerializeField] private string _targetTag;
    [SerializeField] private UnityEvent _afterAttack;
    private bool _canAttack = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DealDamage(collision);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        DealDamage(collision);
    }

    private void CanAttack()
    {
        _canAttack = true;
    }

    private void DealDamage(Collider2D collision)
    {
        if (!_canAttack) return;

        if (collision.CompareTag(_targetTag))
        {
            var damageable = collision.GetComponent<Damageable>();
            damageable.TakeDamage(1);
            TimersManager.SetTimer(this, 1, CanAttack);
            _canAttack = false;
            _afterAttack.Invoke();
        }
    }
}
