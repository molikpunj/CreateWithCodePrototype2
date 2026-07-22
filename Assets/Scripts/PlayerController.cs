using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;
    public Vector2 MoveInput;
    public float Speed;
    public float Limit;
    public GameObject Apple;
    public InputAction FireAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();
        FireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        MoveInput = MoveAction.ReadValue<Vector2>();
        if (transform.position.x >= -Limit && transform.position.x <= Limit)
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime * MoveInput.x);
        }
        if (transform.position.x <= -Limit && MoveInput.x >= 0)
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime * MoveInput.x);
        }
        if (transform.position.x >= Limit && MoveInput.x <= 0)
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime * MoveInput.x);
        }

        if(FireAction.triggered)
        {
            Instantiate(Apple, transform.position, Apple.transform.rotation);
        }
    }
}
