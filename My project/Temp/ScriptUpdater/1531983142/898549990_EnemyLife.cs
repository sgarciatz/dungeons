using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    
    private GameObject  enemyGameObject;
    private Animator    enemyAnimator;

    [Header("Enemy Characteristics")]
    [Tooltip("Life Points of the enemy")]
    [SerializeField] public int LifePoints = 3;


    private void start()
    {
        try {
            enemyGameObject = transform.parent;
            animator        = enemyGameObject.GetComponent<Animator>();
        } catch (Exception e) {
            Debug.Log($"Faulty initialization of enemy Components: \n\tenemyGameObject: {enemyGameObject} \n\animator: {animator} \n\tcollider: {GetComponent<Collider>()}");
        }
    }
    
    private void OnTriggerEnter(Collider other) {
        // Check that the collision is against a weapon

        if (other.tag == "PlayerWeapon") {
            Debub.log("Enemy has been hit");
        }
    }
}
