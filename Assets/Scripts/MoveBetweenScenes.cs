using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveBetweenScenes : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void ExitScene()
    {
        SceneManager.LoadScene("ExitScene");
    }
}
