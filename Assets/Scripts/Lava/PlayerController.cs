using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    private float turnspeed = 10f;
    private float horizontalInput;
    private float forwardInput;
    public GameObject timerObject;
    public Timer timerScript;
    public GameObject punkteObject;
    public Punkteanzeige punkteScript;

    

    // Start is called before the first frame update
    void Start()
    {
        timerObject = GameObject.Find("TimerTextfield");
        timerScript = timerObject.GetComponent<Timer>();

        punkteObject = GameObject.Find("PointsTextfield");
        punkteScript = punkteObject.GetComponent<Punkteanzeige>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // move the vehicle forward
        // transform.Translate(0, 0, 1);

        //Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotates the car based on horizontal Input
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);


        transform.Translate(Vector3.right * Time.deltaTime * turnspeed * horizontalInput);
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Itembox")
        {
            float newX = Random.Range(10, 90);
            float newZ = Random.Range(10, 90);
            col.gameObject.transform.position = new Vector3(newX, 1, newZ);
            timerScript.addTime(5);
        }
        else if(col.gameObject.tag == "PunktePlatte")
        {
            float newX = Random.Range(10, 90);
            float newZ = Random.Range(10, 90);
            col.gameObject.transform.position = new Vector3(newX, 1, newZ);
            punkteScript.addPunkte(1);
        }
    }

}