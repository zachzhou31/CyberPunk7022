using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private static PlayerManager _instance;

    private void Awake()
    {
        _instance = this;
    }
    public static Vector2 PlayerPosition { get {  return  _instance._playerTransform.position; } }
}
