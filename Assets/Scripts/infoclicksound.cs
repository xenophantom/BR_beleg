using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoclicksound : MonoBehaviour
{
    public AudioSource Sounds;
    public AudioClip click_sound;

    public void ClickSound () {
        Sounds.PlayOneShot (click_sound); 
    }
    
}
