using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float gameTime = 90; // Spielzeit in Sekunden
    public TMP_Text timeText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(gameTime > 0)
        {
            gameTime -= Time.deltaTime; 
        }
        else
        {
            gameTime = 0;
            EndGame();
        }
        Display(gameTime);
    }

    void Display(float timeToDisplay)
    {
        if(timeToDisplay < 0 )
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds =  Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void addTime(float timeToAdd)
    {
        this.gameTime += timeToAdd;
    }
   
    private void EndGame()
    {
        // Hier kannst du den Code einfügen, der das Spiel beendet.
        // Du kannst beispielsweise den Application.Quit()-Befehl verwenden, um das Spiel zu beenden.
        // Beachte jedoch, dass dies im Editor nicht funktioniert, sondern nur in der Build-Version.

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif


        Debug.Log("Spiel beendet!");
        Application.Quit();
    }
}
