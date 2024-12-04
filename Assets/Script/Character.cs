using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private IMovementStrategy _movementStrategy;

    void Start()
    {
        // Estrategia predeterminada
        _movementStrategy = new LinearMovement();
    }

    void Update()
    {
        _movementStrategy.Move(transform);
    }

    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        _movementStrategy = strategy;
    }
}