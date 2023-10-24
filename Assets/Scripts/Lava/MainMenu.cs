using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string GameScene; // Name der Startszene

    private void Start()
    {
        // Alle Szenen deaktivieren
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.name != GameScene)
            {
                SceneManager.SetActiveScene(scene);
                SceneManager.UnloadSceneAsync(scene);
            }
        }
    }

    public void StartGame()
    {
        // Startszene aktivieren und laden
        SceneManager.LoadScene(GameScene, LoadSceneMode.Additive);
    }
}
