using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceDistanceTracker : MonoBehaviour
{
    public float despawnDistance = 7.5f;

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x >= despawnDistance)
        {
            Destroy(gameObject);
        }
    }
}
