using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class OpenDoor : MonoBehaviour
{
    private List<GameObject> enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));

    }

    // Update is called once per frame
    void Update()
    {
        // Check if ALL enemies are dead
        List<int> enemiesLifePoints = enemies.Select(enemy => enemy.GetComponent<EnemyLife>().LifePoints).ToList();
        //Debug.Log($"Mostrando la lista de enemigos -> {string.Join(", ", enemiesLifePoints)}");
        if (enemiesLifePoints.All( lp => lp == 0)) {
            Quaternion _targetRot = Quaternion.AngleAxis(-90, transform.up);
            float _rotationSpeed = 5f;
            transform.rotation = Quaternion.Lerp(transform.rotation, _targetRot, _rotationSpeed * Time.deltaTime);
        }
    }

}
