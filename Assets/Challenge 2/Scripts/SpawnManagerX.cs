using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 2;
    private float spawnInterval = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ball fall in " + spawnInterval);
        Invoke("SpawnRandomBall", spawnInterval);
        
    }



    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Random ball index
        int ballIndex = Random.Range(0, ballPrefabs.Length);


        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[0].transform.rotation);

        //Make the spawn interval a random value between 3 seconds and 5 seconds
        int minSecond = 3;
        int maxSecond = 6;
        spawnInterval = Random.Range(minSecond, maxSecond);
        Debug.Log("Next Ball in " + spawnInterval);
        Invoke("SpawnRandomBall", spawnInterval);
       


    }

}
