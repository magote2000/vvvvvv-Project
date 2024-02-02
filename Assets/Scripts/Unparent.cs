using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unparent : MonoBehaviour
{
    public void UnparentSelf()
    {
        transform.parent = null;
    }
}
