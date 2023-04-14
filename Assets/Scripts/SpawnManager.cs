using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject spawn;

    public GameObject[] animalPrefabs;
    [SerializeField] float spawnRangeX = 20;
    [SerializeField] float spawnPositionZ = 20;
    [SerializeField] float startDelay = 3;
    [SerializeField] float spawnIntervals = 1;

    //animalIndex is only needed locally for the if-else statement in this script. no need for public
    //public int animalIndex;

    // Start is called before the first frame update
    void Start()
    {
        //repeatedly calls a method of the method name "SpawnAnimalPrefabs"
        //InvokeRepeating(method to be repeated, delay of start spawn, interval by seconds of spawning);
        InvokeRepeating("SpawnAnimalPrefabs", startDelay, spawnIntervals);
    }

    // Update is called once per frame
    void Update()
    {
        //SpawnAnimalPrefabs();
    }

    void SpawnAnimalPrefabs()
    {
        //Randomly generates index value from 0 - 3 to spawn random animals.
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);


        _ = Instantiate(animalPrefabs[animalIndex].gameObject, spawnPosition, animalPrefabs[animalIndex].transform.rotation);



        /*if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPrefabs[animalIndex].gameObject, spawnPosition, animalPrefabs[animalIndex].transform.rotation);

            /*if (animalIndex < 3)
            {
                animalIndex++;
            }
            else if (animalIndex > 3)
            {
                animalIndex = 0;
            }
            
        }*/
    }
}
