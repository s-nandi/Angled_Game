using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float moveSpeed = 2.5f;
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject playerObject = GameObject.Find("Player");
        if (collision.gameObject == playerObject)
        {
            PlayerController playerController = playerObject.GetComponent<PlayerController>();
            playerController.reduceLife();
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
    }
}
