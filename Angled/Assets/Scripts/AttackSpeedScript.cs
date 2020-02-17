using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackSpeedScript : MonoBehaviour
{

    public Shooting player;
    Text attackSpeed;

    // Start is called before the first frame update
    void Start()
    {
        attackSpeed = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        attackSpeed.text = "Attack Speed: " + player.getAttackSpeed().ToString("F2");
    }
}
