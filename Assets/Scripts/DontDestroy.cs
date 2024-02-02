using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] musicObjects = GameObject.FindGameObjectsWithTag("Music");
        if (musicObjects.Length>1) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
