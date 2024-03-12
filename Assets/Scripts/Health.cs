using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private UnityEvent<int> _healthChanged;
    public int Value { get {  return _health; } }

    public void DecreaseHealth(int amount)
    {
        _health -= amount;
        _healthChanged.Invoke(_health);
    }
}
