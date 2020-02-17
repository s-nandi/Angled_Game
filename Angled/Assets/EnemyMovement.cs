using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float moveSpeed = 2.5f;

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
    }
}
