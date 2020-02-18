using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float coolDownPeriodInSeconds = 0.5f;

    public float bulletForce = 20f;
    private float timeStamp;

    public float getAttackSpeed()
    {
        return 0.5f / coolDownPeriodInSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && timeStamp <= Time.time)
        {
            Shoot();
        }
        if(Input.GetKeyDown("up"))
        {
            coolDownPeriodInSeconds -= 0.01f;
        }
        if(Input.GetKeyDown("down"))
        {
            coolDownPeriodInSeconds += 0.01f;
        }
    }

    void Shoot()
    {
        timeStamp = Time.time + coolDownPeriodInSeconds;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 0.5f);
    }
}
