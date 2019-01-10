using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{

    public GameObject enemySpawn1;
    public GameObject enemySpawn2;
    public GameObject enemySpawn3; 
    // The three row locations where enemies can spawn.
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    //The three different types of enemies, slow, medium and fast.
    private Vector2 enemyRandomSpawn;
    //Vector2 to store the location of the picked spawn.
    private int randomValEnemy;
    //Value used to randomly pick an enemy type.
    private int randomValSpawn;
    //Value used to randomly pick an ememy spawn.

    void Start()
    {
        InvokeRepeating("spawnEnemy", 1, 1); //Runs spawnEnemy() continously after a second.
    }

    public void spawnEnemy()
    {
        randomValEnemy = Random.Range(0, 3); //Sets value of randomValEnemy to 1 or 2.
        randomValSpawn = Random.Range(0, 3); //Sets value of randomValSpawn to 1 or 2.

        if (randomValSpawn == 1)
        {
            enemyRandomSpawn = enemySpawn1.transform.position;
        }
        else if (randomValSpawn == 2)
        {
            enemyRandomSpawn = enemySpawn2.transform.position;
        }
        else
        {
            enemyRandomSpawn = enemySpawn3.transform.position;
        }
        //Simple if else statements deciding the enemy spawn location based on the random value.
        if (randomValEnemy == 1)
        {
            Instantiate(enemy1, enemyRandomSpawn, transform.rotation);
        }
        else if (randomValEnemy == 2)
        {
            Instantiate(enemy2, enemyRandomSpawn, transform.rotation);
        }
        else
        {
            Instantiate(enemy3, enemyRandomSpawn, transform.rotation);
        }
        //Funcion that instantiates a random enemy type based on the value, at the now picked random enemy spawn.
    }
}
