using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weightlogic : MonoBehaviour {
    public GameObject player;
    public GameObject otherWeight;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "p2")
        {
            gameObject.SetActive(false);
            otherWeight.SetActive(true);
            Debug.Log("player2 stole the weight!");
        }

    }
}
