﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score3 : MonoBehaviour
{
    public GameObject Score;
    public GameObject weightActive;
    public GameObject tr2;
    private TimeRemaining tr;
    
    private int timeHeld = 0;
    // Use this for initialization
    void Start()
    {

        tr = tr2.GetComponent<TimeRemaining>();  // IT WORKS! Set new object = gameobject object 
        InvokeRepeating("counter", 1, 1);
    }
    void counter()
    {
        if (weightActive.activeInHierarchy && tr.remainingTime > 0)
        {
            timeHeld = timeHeld + 1;
            Score.GetComponent<Text>().text = "Player 2 Time Held: " + timeHeld;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
