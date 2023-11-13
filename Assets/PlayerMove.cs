using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController player;
    public Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // add left/right movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            body.velocity += Vector3.left * 1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            body.velocity += Vector3.right * 1;
        }
    }
}
