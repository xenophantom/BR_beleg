using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenunew : MonoBehaviour
{
    public GameObject mainMenuPanel;

    private void Start()
    {
        // Deaktiviere das Hauptmenü zu Beginn
        mainMenuPanel.SetActive(true);
    }

    public void StartGame()
    {
         // Füge Debug-Log-Ausgabe hinzu
        Debug.Log("StartGame() aufgerufen");

        // Startszene laden (z.B. "GameWorld")
        SceneManager.LoadScene("GameWorld", LoadSceneMode.Single);

        // Hauptmenü deaktivieren
        mainMenuPanel.SetActive(false);
    }
}
