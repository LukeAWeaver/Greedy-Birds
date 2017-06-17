using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class coinStuff : MonoBehaviour {
    public int points = 5;
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision) //if something touches coin this runs
    {
        Debug.Log("+"+points);
        Destroy(gameObject);
    }
}
