using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int highscore = 0;
    [SerializeField]private TextMeshProUGUI ScoreText;


    public void AddHighscore(){
          highscore++;
          Debug.Log("hallo " + highscore);
          ScoreText.text = "Score: " + highscore;
        }
    
}
