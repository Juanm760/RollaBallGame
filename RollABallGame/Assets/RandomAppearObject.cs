using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAppearObject : MonoBehaviour
{
    public Transform[] Spawnpoints;
    public float Spawntime = 1.5f;
    public GameObject Pickup;
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnPickup", Spawntime, Spawntime);

    }
    void Update()
    {
        
    }
    void SpawnPickup()
    {
        int spawnIndex = Random.Range(0, Spawnpoints.Length);
        Instantiate(Pickup, Spawnpoints[spawnIndex].position, Spawnpoints[spawnIndex].rotation);
    }

}
 

