using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceDistanceTracker : MonoBehaviour
{
    public Score[] scores;
    public float despawnDistance = 1f;

    private void Start () 
    {
        scores = UnityEngine.Object.FindObjectsOfType<Score>();//Sucht nach dem Score.cs Skript :)
    }
    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x >= despawnDistance)
        {
            scores[0].AddHighscore(); 
            Destroy(gameObject);
        }
    }
}
