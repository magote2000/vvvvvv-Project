using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnIntoChild : MonoBehaviour
{
    public GameObject objToChild;
    public GameObject newParent;
    Transform tempTrans;

    public void ChangeParent()
    {
        tempTrans = objToChild.transform.parent;
        objToChild.transform.parent = newParent.transform;
    }

    public void RevertParent()
    {
        objToChild.transform.parent = tempTrans;
    }
}
