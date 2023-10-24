using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
    public GameObject timerObject;
    public Timer timerScript;
    public GameObject punkteObject;
    public Punkteanzeige punkteScript;

    public AudioClip soundClip;

    private bool showText = false;
    private string collisionText = "";
    private GUIStyle labelStyle;


    void Start()
    {
        timerObject = GameObject.Find("TimerTextfield");
        timerScript = timerObject.GetComponent<Timer>();

        punkteObject = GameObject.Find("PointsTextfield");
        punkteScript = punkteObject.GetComponent<Punkteanzeige>();

        soundClip = Resources.Load<AudioClip>("Sounds/SoundInteraction");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Itembox")
        {
            float newX = Random.Range(10, 90);
            float newZ = Random.Range(10, 90);
            col.gameObject.transform.position = new Vector3(newX, 0, newZ);

            collisionText = "Du bekommst 5 Sekunden mehr Zeit!";
            showText = true;
            timerScript.addTime(5);

            Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        else if (col.gameObject.tag == "PunktePlatte")
        {
            float newX = Random.Range(10, 90);
            float newZ = Random.Range(10, 90);
            col.gameObject.transform.position = new Vector3(newX, 1, newZ);
            punkteScript.addPunkte(1);

            Rigidbody rb2 = col.gameObject.GetComponent<Rigidbody>();
            rb2.velocity = Vector3.zero;
            rb2.angularVelocity = Vector3.zero;
        }
        else if (col.gameObject.tag == "Lava")
        {
            
            collisionText = "Lava berührt. -5 Sekunden!";
            showText = true;
            timerScript.addTime(-5);
            AudioSource.PlayClipAtPoint(soundClip, transform.position);
        }


    }
    private void OnGUI()
    {
        if (showText)
        {
            // Hier wird der Text gerendert
            float labelWidth = 800f;
            float labelHeight = 100f;
            float labelX = (Screen.width - labelWidth) / 2f; // Zentriert das Label horizontal
            //float labelY = (Screen.height - labelHeight) / 2f; // Zentriert das Label vertikal

            labelStyle = new GUIStyle(GUI.skin.label);
            labelStyle.fontSize = 24; // Größe des Textes
            labelStyle.normal.textColor = Color.red; // Farbe des Textes


            GUI.Label(new Rect(labelX, 10, labelWidth, labelHeight), collisionText, labelStyle);
        }
    }
}
