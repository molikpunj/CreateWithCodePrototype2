using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float UpperBounds;
    public float LowerBounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= UpperBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z <= LowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
