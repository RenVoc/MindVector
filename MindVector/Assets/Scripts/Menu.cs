using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void startFunction()
    {
        SceneManager.LoadScene("FirstChapt");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void History()
    {
        SceneManager.LoadScene("History");
    }
    public void Achievement()
    {
        SceneManager.LoadScene("Achievement"); 
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Authors()
    {
        SceneManager.LoadScene("Authors");
    }
}
