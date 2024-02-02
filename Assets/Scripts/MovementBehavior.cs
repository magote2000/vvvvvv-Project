using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    private Vector3 _direction;
    private float _velocity;

    public void Init(Vector3 dir, float vel)
    {
        _direction = dir;
        _velocity = vel;
    }

    public void Move()
    {
        transform.position = transform.position + _direction * _velocity;
    }
    public void Move(Vector3 direction, float velocity)
    {
        transform.position +=  direction * velocity * Time.deltaTime;
    }

    public void Move(Vector3 position)
    {
        transform.position += position;
    }

    public void MoveTo(float x, float y)
    {
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
