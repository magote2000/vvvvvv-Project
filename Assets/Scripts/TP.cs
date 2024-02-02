using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    public GameObject tpCam;
    public GameObject tpPlayer;
    public GameObject cam;
    public GameObject player;

    public void Teleport()
    {
        cam.GetComponent<MovementBehavior>().MoveTo(tpCam.transform.position.x, tpCam.transform.position.y);
        player.GetComponent<MovementBehavior>().Move(new Vector3
            (tpPlayer.transform.position.x - transform.position.x,
            tpPlayer.transform.position.y - transform.position.y, 0));
    }

    public void TeleportTo()
    {
        cam.GetComponent<MovementBehavior>().MoveTo(tpCam.transform.position.x, tpCam.transform.position.y);
        player.GetComponent<MovementBehavior>().MoveTo(tpPlayer.transform.position.x, tpPlayer.transform.position.y);
    }
}
