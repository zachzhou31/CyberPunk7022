using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Health _health;

    private void Awake()
    {
        _healthBar.maxValue = _health.Value;
        _healthBar.value = _health.Value;
    }

    public void UpdateUI()
    {
        _healthBar.value = _health.Value;
    }
}
