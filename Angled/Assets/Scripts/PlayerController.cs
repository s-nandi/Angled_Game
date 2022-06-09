using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField] private int startingLives;
    // General
    public Rigidbody2D rb;
    private int lives;

    // Movement
    //public float moveSpeed = 5f;
    private float walkSpeed;
    private float curSpeed;
    private float maxSpeed;

    // Aiming
    public Camera cam;
    Vector2 mousePos;

    void Start()
    {
        lives = startingLives;
        walkSpeed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Input
        //movement.x = Input.GetAxis("Horizontal");
        //movement.y = Input.GetAxis("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (lives <= 0) Application.Quit();
    }

    // Fixed Update (called 50 times a second)
    void FixedUpdate()
    {
        // Movement
        curSpeed = walkSpeed;
        maxSpeed = curSpeed;
        rb.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f), Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f));
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
        // Aiming
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90;
        rb.rotation = angle;
    }

    public int GetLives()
    {
        return lives;
    }
}
