using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trave_person : MonoBehaviour {

    // Use this for initialization


    public GameObject Person;
    private int i;

    // Update is called once per frame
    void Update()
    {
        i++;
        if (!spawning && (i%120==0))
        {
            StartCoroutine(SpawnPillarAfterDelay());
        }
    }

    bool spawning = false;
    IEnumerator SpawnPillarAfterDelay()
    {
        spawning = true;
        yield return new WaitForSeconds(0.1f);
     

        GameObject.Instantiate(
           Person,
           new Vector2(250, 130),
           Quaternion.identity
           );
        spawning = false;
    }
}
