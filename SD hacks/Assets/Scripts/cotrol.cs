using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cotrol : MonoBehaviour {
    private int speed = 1;
    
    Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {

            rb.velocity = new Vector2(0, speed);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.velocity = (new Vector2(0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
           

            rb.velocity = new Vector2(-speed, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {

            rb.velocity = (new Vector2(0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {


            rb.velocity = new Vector2(0, -speed);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.velocity = (new Vector2(0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {


            rb.velocity = new Vector2(speed, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = (new Vector2(0, 0));
        }
    }
}
