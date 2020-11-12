using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string loadLevel;
    public GameObject loadingScreen;

    public void startFunction()
    {
        SceneManager.LoadScene("FirstChapt");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Load()
    {
        loadingScreen.SetActive(true);
        SceneManager.LoadScene(loadLevel);
    }
}
