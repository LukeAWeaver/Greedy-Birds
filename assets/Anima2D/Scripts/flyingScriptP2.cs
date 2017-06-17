using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingScriptP2 : MonoBehaviour
{
    private float velocity = .4f;
    public float vlimit;
    public float hlimit;

    public GameObject coin;
    public GameObject collisionObject;
    public GameObject smallObject;

    
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (smallObject.activeInHierarchy == false)
        {
            velocity = .4f;
        }
        else if (smallObject.activeInHierarchy)
        {
            velocity = .3f;
        }
        /*
        vlimit = Input.GetAxis("Vertical");
        hlimit = Input.GetAxis("Horizontal");
        if(Input.GetAxis("Vertical") <.1f && Input.GetAxis("Vertical") > -.1f)
        {
            transform.Translate(0f, Input.GetAxis("Vertical"), 0f);

        }
        else if (Input.GetAxis("Vertical") > .1f )
        {
            vlimit = .1f;
            transform.Translate(0f, vlimit, 0f);
        }
        else if (Input.GetAxis("Vertical") < -.1f)
        {
            vlimit = -.1f;
            transform.Translate(0f, vlimit, 0f);

        }
        if (Input.GetAxis("Horizontal") < .1f && Input.GetAxis("Horizontal") > -.1f)
        {
            transform.Translate(Input.GetAxis("Horizontal"), 0f, 0f);

        }

        else if (Input.GetAxis("Horizontal") > .1f)
        {
            hlimit = -.1f;
            transform.Translate(hlimit, 0f, 0f);

        }
        else if (Input.GetAxis("Horizontal") < -.1f)
        {
            hlimit = .1f;
            transform.Translate(hlimit, 0f, 0f);

        }

    */



        if (Input.GetKey("right") )
        {
            Flip("right");
            transform.Translate(-velocity, 0f, 0f);
        }
        if (Input.GetKey("left"))
        {
            Flip("left");
            transform.Translate(velocity, 0f, 0f);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(0f, velocity, 0f);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0f, -velocity, 0f);
        }
    }
    public void Flip(string flip)
    {
        var theScale = transform.localScale;
        if (flip == "left")
        {
            if (theScale.x < -.1f)
                theScale.x = -theScale.x;
        }
        if (flip == "right")
        {
            if (theScale.x > .1f)
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
            Debug.Log(collision.gameObject.name + " detected!");
        }
        if (collision.gameObject.name == "16g")
        {
            smallObject.SetActive(true);
        }

    }


}
