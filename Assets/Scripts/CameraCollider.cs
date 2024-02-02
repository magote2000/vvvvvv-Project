using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollider : MonoBehaviour
{
    public float offset;
    public int xdir;
    public int ydir;
    public GameObject cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cam.GetComponent<MovementBehavior>().Move(new Vector3(xdir*offset, ydir*offset, 0));
    }
}
