using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weightlogic2 : MonoBehaviour
{
    public GameObject player;
    public GameObject otherWeight;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "p1")
        {
            gameObject.SetActive(false);
            otherWeight.SetActive(true);
            Debug.Log("p1 stole the weight!");
        }

    }
}
