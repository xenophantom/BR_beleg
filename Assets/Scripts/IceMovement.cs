using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMovement : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public float constantMoveSpeed = 1f;
    public Vector3 constantMoveDirection = Vector3.right;

    //private BoxCollider bc;

    // Start is called before the first frame update
    void Start()
    {
        //bc = GetComponent<BoxCollider>();
        //gameObject.tag = "Ice";
    }

    // Update is called once per frame
    void Update()
    {

        // Zufällige Bewegung auf der Z-Achse
        //Vector3 randomMovement = new Vector3(0f, 0f, Random.Range(-1f, 1f)).normalized;
        //Vector3 movement = randomMovement * moveSpeed * Time.fixedDeltaTime;

        //zufällige Geschwindigkeit
        float randomSpeed = Random.Range(0f, moveSpeed);

        // Konstante Bewegung auf der X-Achse
        Vector3 constantMovement = constantMoveDirection * constantMoveSpeed * randomSpeed * Time.fixedDeltaTime;

        // Bewegung
        //bc.MovePosition(bc.position + constantMovement);
        

    }
}
