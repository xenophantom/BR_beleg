using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceDistanceTracker : MonoBehaviour
{
    public float despawnDistance = 7.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x >= despawnDistance)
        {
            Destroy(gameObject);
        }
    }
}
