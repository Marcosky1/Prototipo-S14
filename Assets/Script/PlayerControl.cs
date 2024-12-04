using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Character character;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            character.SetMovementStrategy(new LinearMovement());
            Debug.Log("Cambio a LinearMovement");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            character.SetMovementStrategy(new ZigzagMovement());
            Debug.Log("Cambio a ZigzagMovement");
        }
    }
}
