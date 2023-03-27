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


    private void Start()
    {
            enemyGameObject = this.gameObject;
            enemyAnimator   = enemyGameObject.GetComponent<Animator>();
            enemyAnimator.SetInteger("LifePoints", LifePoints);
            //Debug.Log($"Initialization of enemy Components: \n\tenemyGameObject: {enemyGameObject} \n\tanimator: {enemyAnimator}");

    }
    
    private void OnTriggerEnter(Collider other) {
        // Check that the collision is against a weapon

        if (other.tag != "PlayerWeapon" || LifePoints == 0) { return; }
        string playerCurrentAnimation = GameObject.Find("PlayerArmature")
                                                    .GetComponent<Animator>()
                                                        .GetCurrentAnimatorClipInfo(0)[0].clip.name;
        if (playerCurrentAnimation != "MeleeAttack_TwoHanded") { return; }  

        //Debug.Log("Enemy has been hit");
        //Debug.Log(enemyAnimator);
        enemyAnimator.SetTrigger("Hit");
        enemyAnimator.SetInteger("LifePoints", --LifePoints);
    }
}
