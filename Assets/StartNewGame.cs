using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNewGame : MonoBehaviour
{
    public void StartGame () {
        SceneManager.LoadScene("GameWorld");
    }

    public void MainMenu () {
        SceneManager.LoadScene("MainMenu");
    }

}
