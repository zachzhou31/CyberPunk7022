using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCreator : MonoBehaviour
{
    [SerializeField] private GameObject _misslePrefab;
    [SerializeField] private Transform _playerTransform;

    public void CreateMissile()
    {
        Instantiate(_misslePrefab, _playerTransform.position,Quaternion.identity);
    }
}
