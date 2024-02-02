using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCheckPoint : MonoBehaviour
{
    public GameObject objectToSpawn;

    public void SetNewPoint()
    {
        objectToSpawn.GetComponent<LastCheckPoint>().UpdateCheckPoint(gameObject);
    }
}
