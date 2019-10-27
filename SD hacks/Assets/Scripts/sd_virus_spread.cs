using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sd_virus_spread : MonoBehaviour {

    // Use this for initialization


    public GameObject Virus_sprite;
   // public float number_case = 0.0f;
    public static float sd_totalinfected = 1000;
    // Update is called once per frame
    void Update()
    {
        if (!spawning)
        {
            StartCoroutine(SpawnPillarAfterDelay());
        }
    }

    bool spawning = false;
    IEnumerator SpawnPillarAfterDelay()
    {
        spawning = true;
        yield return new WaitForSeconds(0.1f);
        if (sd_curerate.sd_number_case >= 300)
        {
            GameObject.Instantiate(
              Virus_sprite,
              new Vector2(UnityEngine.Random.Range(520, 580.0f), UnityEngine.Random.Range(50, 100.0f)),
              Quaternion.identity
              );

        }
        if (sd_curerate.sd_number_case >= sd_totalinfected)
        {
            GameObject.Instantiate(
              Virus_sprite,
              new Vector2(UnityEngine.Random.Range(520, 560.0f), UnityEngine.Random.Range(100, 124.0f)),
              Quaternion.identity
              );

        }

        GameObject.Instantiate(
             Virus_sprite,
             new Vector2(UnityEngine.Random.Range(520, 580.0f), UnityEngine.Random.Range(50, 100.0f)),
             Quaternion.identity
             );


        spawning = false;
    }
}
