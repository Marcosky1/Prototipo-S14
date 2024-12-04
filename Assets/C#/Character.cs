using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private IMovementStrategy movementStrategy;

    void Start()
    {
        SetMovementStrategy(new LinearMovement());
    }

    void Update()
    {
        movementStrategy.Move(transform);

        if (Input.GetKeyDown(KeyCode.S))
        {
            SetMovementStrategy(new ZigzagMovement());
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            SetMovementStrategy(new LinearMovement());
        }
    }

    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        movementStrategy = strategy;
    }
}