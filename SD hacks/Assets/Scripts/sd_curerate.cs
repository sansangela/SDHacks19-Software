using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sd_curerate : MonoBehaviour {

    public static float sd_cure = 10.0f;
    private int i = 0;

    public static float sd_number_case = 0.0f;
    // Use this for initialization
    void Start()
    {
        sd_number_case = sd_number_case - 5;
       // Debug.Log(sd_number_case);
    }

    // Update is called once per frame
    void Update()
    {

        i++;

        if (i % 60 == 0)
        {
            sd_number_case += 1;
        }

        Destroy(gameObject, sd_cure);



    }
}
