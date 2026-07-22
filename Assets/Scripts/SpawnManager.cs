using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    public int Range;
    public float StartDelay;
    public float Interval;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnAnimals", StartDelay, Interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnAnimals()
    {
        int AnimalIndex = Random.Range(0, 3);
        Vector3 SpawnPos = new Vector3(Random.Range(-Range, Range), 0, 25);
        Instantiate(AnimalPrefabs[AnimalIndex], SpawnPos, AnimalPrefabs[AnimalIndex].transform.rotation);
    }
}
