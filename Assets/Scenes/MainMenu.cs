using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using static System.Net.Mime.MediaTypeNames;

public class MainMenu : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
