using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceDistanceTracker : MonoBehaviour
{
    public Vector3 startPosition;
    public float despawnDistance = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Vector3.Distance(startPosition, transform.position);
        if (distance >= despawnDistance)
        {
            Destroy(gameObject);
        }
    }
}
