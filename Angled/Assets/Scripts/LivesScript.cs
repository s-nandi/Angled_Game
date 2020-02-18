﻿using System.Collections;
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
        lives.text = "Lives: " + GameObject.Find("Player").GetComponent<PlayerController>().lives.ToString();
    }
}
