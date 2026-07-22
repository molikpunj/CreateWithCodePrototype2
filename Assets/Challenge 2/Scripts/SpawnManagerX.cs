using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", 3);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int randomNum = Random.Range(0, 3);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomNum], spawnPos, ballPrefabs[randomNum].transform.rotation);
        int Interval = Random.Range(3, 6);
        Invoke("SpawnRandomBall", Interval);
    }

}
