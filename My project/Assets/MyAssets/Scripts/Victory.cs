using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) {
        if (other.tag != "Player") { return; }
        Debug.Log("WIN");
        SceneManager.LoadScene ("SampleScene");
    
    }
}
