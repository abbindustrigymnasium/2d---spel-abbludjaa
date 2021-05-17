using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour
{
    //public Transform Player;
    public Text scoreText;
    public float playerHighY = 1;

    // Update is called once per frame
    void Update()
    {
        playerHighY = GameObject.Find("Player").GetComponent<DeathScript>().HighY;
        scoreText.text = "  Score: " + playerHighY.ToString("0");
    }
}
