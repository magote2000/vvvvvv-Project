using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCheckPoint : MonoBehaviour
{
    public GameObject lastCheckPoint;
    
    public void UpdateCheckPoint(GameObject checkPoint)
    {
        lastCheckPoint = checkPoint;
    }

    public GameObject GetLastCheckpoint()
    {
        return lastCheckPoint;
    }
}
