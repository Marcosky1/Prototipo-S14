using UnityEngine;

// Strategy Interface
public interface IMovementStrategy
{
    void Move(Transform transform);
}

// Concrete Strategies
public class LinearMovement : IMovementStrategy
{
    public void Move(Transform transform)
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}

public class ZigzagMovement : IMovementStrategy
{
    private float angle = 0f;

    public void Move(Transform transform)
    {
        angle += Time.deltaTime * 5f;
        transform.Translate(new Vector3(Mathf.Sin(angle), 0, 1) * Time.deltaTime);
    }
}

