using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingScript : MonoBehaviour {
    private float velocity = .4f;
    public GameObject coin;
    public GameObject collisionObject;
    public GameObject smallObject;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (smallObject.activeInHierarchy == false)
        {
            velocity = .4f;
        }
        else if (smallObject.activeInHierarchy)
        {
            velocity = .3f;
        }



        if (Input.GetKey("l"))
        {
            Flip("right");
            transform.Translate(-velocity, 0f, 0f);
        }
        if (Input.GetKey("j"))
        {
            Flip("left");
            transform.Translate(velocity, 0f, 0f);
        }
        if (Input.GetKey("i"))
        {
            
            transform.Translate(0f, velocity, 0f);
        }
        if (Input.GetKey("k"))
        {
            transform.Translate(0f, -velocity, 0f);
        }
    }
    public void Flip(string flip)
    {
        var theScale = transform.localScale;
        if(flip == "left")
        {
            if(theScale.x <-.1f)
            theScale.x = -theScale.x;
        }
        if(flip == "right")
        {
            if(theScale.x > .1f)
            theScale.x = -theScale.x;
        }
        transform.localScale = theScale;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "16kg")
        {
            collisionObject.SetActive(false);
            smallObject.SetActive(true);
            velocity = .1f;
            Debug.Log(collision.gameObject.name +" detected!");
        }
        if(collision.gameObject.name == ".16g2")
        {
            smallObject.SetActive(true);
        }

    }


}
