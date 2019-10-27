using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sf_flight : MonoBehaviour {

    public float movemnet_speed = 0.4f;
    public float movemnet_speed2 = 0.28f;
    public Sprite infected;
    // Use this for initialization
    void Start()
    {

        if (cure_rate.number_case >= 1000)
        {
            Debug.Log("Yes");
            GetComponent<SpriteRenderer>().sprite = infected;
        }
        Destroy(gameObject,2);

    }



    // Update is called once per frame
    void Update()
    {


        transform.Translate(Vector2.up * movemnet_speed);
        transform.Translate(Vector2.right * movemnet_speed2);
        

    }
    
}
