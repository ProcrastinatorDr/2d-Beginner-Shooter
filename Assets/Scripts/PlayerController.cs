using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    public InputAction MoveAction;
    public float CharacterSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter(CharacterSpeed);
    }
    private void MoveCharacter(float characterSpeed)
    {
        Vector2 position = transform.position;

        position += GetMovement(characterSpeed);

        transform.position = position; 
    }
    private Vector2 GetMovement(float characterSpeed)
    {
        Vector2 movementVector = MoveAction.ReadValue<Vector2>();
        return movementVector*characterSpeed*Time.deltaTime;
    }
}
