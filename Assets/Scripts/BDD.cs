using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using UnityEngine.SceneManagement;

public class BDD : MonoBehaviour
{
    private bool canDelete = false;
    public GameObject buttonPrefab;
    public Transform scrollview;

    public UnityEvent<string> changeMode;

    private void Start()
    {
        List<int> ids = DBManager.GetAllIds();
        for (int i=0; i < DBManager.TotalCount(); i++){

            GameObject button = (GameObject)Instantiate(buttonPrefab);
            button.GetComponentInChildren<Text>().text = ids[i].ToString();
            button.GetComponent<Button>().onClick.AddListener(
                    () => { LoadGame(button); });
            button.transform.SetParent(scrollview);
            button.transform.localScale = Vector2.one;
        }
    }
    public void LoadGame(GameObject button)
    {
        string name = button.GetComponentInChildren<Text>().text;
        if (canDelete)
        {
            DBManager.DeleteGame(int.Parse(name));
            Destroy(button);
        }
        else
        {
            Debug.Log(name);
            Debug.Log(int.Parse(name));
            DBManager.ActualGameId = int.Parse(name);
            Debug.Log(name);
            SceneManager.LoadScene("Game");
        }      
    }
    public void AddGame()
    {
        GameObject button = (GameObject)Instantiate(buttonPrefab);
        DBManager.NewGame();
        int id = DBManager.GetLastId();
        button.GetComponentInChildren<Text>().text = id.ToString();
        button.GetComponent<Button>().onClick.AddListener(
                () => { LoadGame(button); });
        button.transform.SetParent(scrollview);
        button.transform.localScale = Vector2.one;
    }

    public void ChangeMode()
    {
        canDelete = !canDelete;
        if (canDelete)
        {
            changeMode.Invoke("REMOVE ON");
        }
        else
        {
            changeMode.Invoke("REMOVE OFF");
        }
    }
}
