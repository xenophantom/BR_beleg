using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterControl : MonoBehaviour
{
    CharacterController characterController;
    float moveSpeed = 1f;

     void Start(){
        characterController = GetComponent<CharacterController>();
     }


     void Update(){
        float moveZ = Input.GetAxisRaw("Vertical");

        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveZ = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveZ = -1f;
        }

        Vector3 moveVector = new Vector3(0f, 0f, moveZ) * moveSpeed;
        characterController.Move(moveVector * Time.deltaTime);

        LimitPlayerPosition();
     }

     void LimitPlayerPosition(){
        float minX = -5f; 
        float maxX = 5f;  

        Vector3 currentPosition = transform.position;

        currentPosition.x = Mathf.Clamp(currentPosition.x, minX, maxX);

        transform.position = currentPosition;
     }

    
    
}
