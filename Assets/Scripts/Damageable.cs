using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] SpriteRenderer _spriteRenderer;

    private Color _defaultColor;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _defaultColor = _spriteRenderer.color;
    }

    public void TakeDamage(int damage)
    {
        _health.DecreaseHealth(damage);
        _spriteRenderer.DOColor(Color.red, .2f).SetLoops(2,LoopType.Yoyo).ChangeStartValue(_defaultColor); //.2√Î∫Û…¡∫Ï
    }
}
