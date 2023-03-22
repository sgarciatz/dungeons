using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {   
        if (other.tag == "Enemy") {
            Debug.Log("HOLAAAAAAAAAAAA"); 
        
        }
    }
}
