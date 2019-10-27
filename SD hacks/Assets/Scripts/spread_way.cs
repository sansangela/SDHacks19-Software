using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spread_way : MonoBehaviour {

    public float movemnet_speed = 2.0f;
    private float direction;
    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        // if (flying.isDead == false)
        direction = UnityEngine.Random.Range(0, 4.0f);
        if (direction >3)
        { transform.Translate(Vector2.down * movemnet_speed); }
        else if (direction>2)
        { transform.Translate(Vector2.up * movemnet_speed); }
        else if (direction >1)
        { transform.Translate(Vector2.left * movemnet_speed); }
        else if (direction > 0)
        { transform.Translate(Vector2.right * movemnet_speed); }

    }
}
