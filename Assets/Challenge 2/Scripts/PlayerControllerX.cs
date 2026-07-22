using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction fireAction;
    public bool isshootingallowed = true;

    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (fireAction.triggered)
        {
            if (isshootingallowed == false)
            {
                return;
            }
            else
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                isshootingallowed = false;
                Invoke("IsShootingAllowedFlip", 1);
            }
        }
    }
    void IsShootingAllowedFlip()
    {
        isshootingallowed = !isshootingallowed;
    }
}
