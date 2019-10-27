using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warning_active : MonoBehaviour {
    public GameObject Warning;
    public GameObject Warning1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (cure_rate.number_case >= 1000)
        {
            Warning.SetActive(true);
        }

        if (sd_curerate.sd_number_case >= sd_virus_spread.sd_totalinfected)
        {
            Warning1.SetActive(true);
        }

    }
}
