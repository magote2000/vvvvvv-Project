using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseCanvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused) Resume();
            else Pause();
        }
    }

    void Pause()
    {
        pauseCanvas.SetActive(true);
        gamePaused = true;
        Time.timeScale = 0f;
        GetComponent<EventCaller>().CallEvent();
    }

    public void Resume()
    {
        pauseCanvas.SetActive(false);
        gamePaused = false;
        Time.timeScale = 1f;
        GetComponent<EventCaller>().CallEvent();
    }
}
