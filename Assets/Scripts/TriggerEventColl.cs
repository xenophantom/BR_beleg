using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEventColl : MonoBehaviour
{

    public GameObject GameOver; 
    public GameObject IceGenerator;
    public GameObject Rotation; 
    public GameObject Character;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ice" )
        {
           GameOver.SetActive(true);
           IceGenerator.SetActive(false); 
           Rotation.SetActive(false); 
           Character.SetActive(false);
            
        }
    }

}
