using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    public float rotationSpeed = 0.5f;

    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Kameraposition
        transform.position = player.transform.position + offset;

        // Kamerarichtung
        float horizontalRotation = Input.GetAxis("Horizontal") * rotationSpeed;
        transform.RotateAround(player.transform.position, Vector3.up, horizontalRotation);
    }
}