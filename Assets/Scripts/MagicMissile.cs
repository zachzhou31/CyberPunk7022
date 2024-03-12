using Timers;
using UnityEngine;

public class MagicMissile : MonoBehaviour
{
    [SerializeField] private MissileCreator _creator;
   public void LauchMissile()
    {
        _creator.CreateMissile();
    }

    private void Awake()
    {
        LauchMissile();
        TimersManager.SetLoopableTimer(this, 1, LauchMissile);
    }
}
