using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

    public float movemnet_speed = 0.1f;
    public float movemnet_speed2 = 0.07f;
    public Sprite infected;
    // Use this for initialization
    void Start()
    {

        if (cure_rate.number_case >= 1000)
        {
            Debug.Log("Yes");
            GetComponent<SpriteRenderer>().sprite = infected;
        }

    }

    

    // Update is called once per frame
    void Update()
    {
        

        transform.Translate(Vector2.down * movemnet_speed);
        transform.Translate(Vector2.right * movemnet_speed2);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.GetComponent<San_diego_system>() != null)
            {
            Destroy(gameObject);

        }

        }

}

