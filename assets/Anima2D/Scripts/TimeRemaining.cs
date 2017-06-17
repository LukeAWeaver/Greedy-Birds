using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRemaining : MonoBehaviour
{
    public GameObject Score;
    public int remainingTime = 60;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("counter", 1, 1);
    }
    void counter()
    {

            if (remainingTime > 0)
            {
                remainingTime = remainingTime - 1;
                Score.GetComponent<Text>().text = "TIME REMAINING: " + remainingTime;
            }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
