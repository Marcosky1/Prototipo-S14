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
    [SerializeField] private float _zigzagSpeed = 5f;
    [SerializeField] private float _frequency = 2f;

    public void Move(Transform transform)
    {
        float zigzag = Mathf.Sin(Time.time * _frequency) * _zigzagSpeed * Time.deltaTime;
        transform.Translate(new Vector3(zigzag, 0, 5 * Time.deltaTime));
    }
}

