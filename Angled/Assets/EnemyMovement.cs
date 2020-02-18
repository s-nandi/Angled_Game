using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float moveSpeed = 2.5f;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(GameObject.Find("Player").GetComponent<PlayerController>().lives > 0)
                GameObject.Find("Player").GetComponent<PlayerController>().lives--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
    }
}
