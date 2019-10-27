using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flight_moving : MonoBehaviour
{

    public float movemnet_speed = 0.4f;
    public float movemnet_speed2 = 0.28f;
    public Sprite infected;
    // Use this for initialization
    void Start()
    {

        if (sd_curerate.sd_number_case >= sd_virus_spread.sd_totalinfected)
        {
            GetComponent<SpriteRenderer>().sprite = infected;
        }

    }



    // Update is called once per frame
    void Update()
    {


        transform.Translate(Vector2.up * movemnet_speed);
        transform.Translate(Vector2.left * movemnet_speed2);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<trave_person>() != null)
        {
            Destroy(gameObject);

            if (sd_curerate.sd_number_case >= sd_virus_spread.sd_totalinfected)
            {
                cure_rate.number_case+= 400;
            }

        }
    }
}


