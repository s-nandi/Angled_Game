using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        } else if (collision.gameObject.tag == "Enemy"){
            Destroy(collision.gameObject);
            ScoreScript.scoreValue += 50;
            if(GameObject.Find("Player").GetComponent<Shooting>().coolDownPeriodInSeconds > 0.05) GameObject.Find("Player").GetComponent<Shooting>().coolDownPeriodInSeconds -= 0.005f;
        }
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(effect, 0.2f);
    }


}
