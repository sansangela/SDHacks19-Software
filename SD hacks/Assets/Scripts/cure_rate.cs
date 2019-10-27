using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cure_rate : MonoBehaviour {
    public static float cure=6.0f;
    private int i = 0;
    
    public static float number_case = 0.0f;
    // Use this for initialization
    void Start () {
        number_case = number_case - 5;
        Debug.Log(number_case);
        Debug.Log("cure_time"+cure);
    }
	
	// Update is called once per frame
	void Update () {
       
        i++;
        
        if (i%50==0)
        {
            number_case += 1;
        }

        Destroy(gameObject, cure);
      
        

    }
}
