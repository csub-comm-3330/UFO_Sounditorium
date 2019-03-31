using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOSpawner : MonoBehaviour
{
    public float timeBetweenSpawns = 10;
    public GameObject[] UFOPrefab = new GameObject[2];
    //public GameObject EvilUFO;
    //public GameObject PoliceUFO;
    float lastSpawn = 0;
    Vector3 spawnPoint;
    Vector3 randomSpawn;


    private void Start()
    {
        //for(int p = 0; p < UFOPrefab.Length; p++)
        //{
        //  UFOPrefab[p] = Resources.Load(EvilUFO, PoliceUFO) as GameObject;
        //}
        // UFOPrefab[0] = EvilUFO;
        //UFOPrefab[1] = PoliceUFO;
        spawnPoint = gameObject.transform.position;

    }

    void Update()
    {
        randomSpawn = spawnPoint + new Vector3(0, Random.Range(.5f, 4f), Random.Range(-30, 30));
        if (lastSpawn + timeBetweenSpawns < Time.time)
        {
            Instantiate(UFOPrefab[Random.Range(0, UFOPrefab.Length)], randomSpawn, transform.rotation); 
            lastSpawn = Time.time;
        }
    }
}
