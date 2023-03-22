using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [Header("Player")]
    [Tooltip("Move speed of the character in m/s")]
    private int _LifePoints = 3;
    public int LifePoints
    {
        get
        {
            return _LifePoints;
        }
        set
        {
            _LifePoints = value;
        }
    }
    
}
