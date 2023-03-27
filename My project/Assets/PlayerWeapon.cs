using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    private Animator playerAnimator;
    private Collider weaponCollider;

    // Start is called before the first frame update
    void Start()
    {
        try {
            GameObject player = GameObject.Find("PlayerArmature");
            playerAnimator = player.GetComponent<Animator>();
        } catch {
            Debug.Log("GameObject PlayerArmature not found");
        }



    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerAnimator.GetCurrentAnimatorClipInfo(0)[0].clip);
    }


    private void OnTriggerEnter(Collider other) {
        if ( (other.tag == "Enemy") && 
             (playerAnimator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "MeleeAttack_TwoHanded") ) {
    
            Debug.Log("Ataque enemigo");
        }
    }

}
