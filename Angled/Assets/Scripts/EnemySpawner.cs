using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    int spawnRate = 60; // Frames
    int counter =   0;  // Frames

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        if(counter > spawnRate)
        {
            counter = 0;
            float choice = Random.value;
            if(choice < 0.25f)
            {
                randX = Random.Range(player.transform.position.x - 8.6f, player.transform.position.x + 8.6f);
                randY = player.transform.position.y + 4.5f;
            } else if(choice < 0.5f)
            {
                randX = Random.Range(player.transform.position.x - 8.6f, player.transform.position.x + 8.6f);
                randY = player.transform.position.y - 4.5f;
            } else if (choice < 0.5f)
            {
                randX = player.transform.position.y - 8.6f;
                randY = Random.Range(player.transform.position.y - 4.5f, player.transform.position.y + 4.5f);
            } else
            {
                randX = player.transform.position.y + 8.6f;
                randY = Random.Range(player.transform.position.y - 4.5f, player.transform.position.y + 4.5f);
            }
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
        counter++;
    }
}
