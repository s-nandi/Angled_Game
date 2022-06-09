using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesScript : MonoBehaviour
{

    Text lives;

    // Start is called before the first frame update
    void Start()
    {
        lives = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController playerContoller = GameObject.Find("Player").GetComponent<PlayerController>();
        lives.text = "Lives: " + playerContoller.GetLives().ToString();
    }
}
