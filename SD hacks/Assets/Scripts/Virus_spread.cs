using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus_spread : MonoBehaviour {

    // Use this for initialization


    public GameObject Virus_sprite;
    public float number_case = 0.0f;
    public static float totalinfected = 1000;
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
        if (cure_rate.number_case >= 100)
        {
            GameObject.Instantiate(
              Virus_sprite,
              new Vector2(UnityEngine.Random.Range(0, 80.0f), UnityEngine.Random.Range(-10, 70.0f)),
              Quaternion.identity
              );

        }
        if (cure_rate.number_case >= totalinfected)
        {
            GameObject.Instantiate(
              Virus_sprite,
              new Vector2(UnityEngine.Random.Range(0, 80.0f), UnityEngine.Random.Range(-10, 70.0f)),
              Quaternion.identity
              );

        }

        GameObject.Instantiate(
             Virus_sprite,
             new Vector2(UnityEngine.Random.Range(0, 80.0f), UnityEngine.Random.Range(-10, 70.0f)),
             Quaternion.identity
             );


        spawning = false;
    }
}
