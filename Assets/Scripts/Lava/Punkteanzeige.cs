using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Punkteanzeige : MonoBehaviour
{
    public int Punkte = 0;
    public TMP_Text punkteText;


    // Start is called before the first frame update
    void Start()
    {
    }

    public void addPunkte(int Punkte)
    {
        this.Punkte += Punkte;
    }

    void Display()
    {
        punkteText.text = string.Format("Punkte: {0}", Punkte);
    }

    // Update is called once per frame
    void Update()
    {
        Display();
    }
}
