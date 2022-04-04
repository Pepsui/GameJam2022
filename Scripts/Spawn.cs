using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objects;
     public float spawnTime = 6f;            // How long between each spawn.
     private Vector3 spawnPosition;
 
     // Use this for initialization
     void Start () 
     {
         // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
         InvokeRepeating ("SpawnPoints", spawnTime, spawnTime);
        SpawnPoints();
        SpawnRandom();
     }
 
     void SpawnPoints()
     {
         spawnPosition.x = Random.Range (-17, 17);
         spawnPosition.y = 0.5f;
         spawnPosition.z = Random.Range (-17, 17);
 
         Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
     }
     public void SpawnRandom()
     {
         Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)]);
     }

    // Update is called once per frame
    void Update()
    {

    }
}
