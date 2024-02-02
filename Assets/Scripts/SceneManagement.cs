using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public static void ReturnMainMenu()
    {
        SceneManager.LoadScene("main menu");
    }
    public static void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public static void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public static void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public static void Load()
    {
        SceneManager.LoadScene("Scrollview");
    }

    public static void Win()
    {
        SceneManager.LoadScene("Win");
    }

    public static void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
