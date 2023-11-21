using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Buoyancy : MonoBehaviour
{
    public float underwaterDrag = 3f;
    public float underwaterAngularDrag = 1f;
    public float airDrag = 0f;
    public float airAngularDrag = 0.05f;
    public float floatingPower = 15f;
    public float waterHeight = 0f;

    Rigidbody m_Rigidbody;
    public Transform[] floaters;
    
    bool isUnderwater;
    int floatersUnderwater;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody= GetComponent<Rigidbody>();
    }

    // FixedUpdate is used for physics calculations, it's in sync w/ the physics engine
    void FixedUpdate() {
        floatersUnderwater = 0;

        for (int i = 0; i < floaters.Length; i++) {
            float diff = floaters[i].position.y - waterHeight;

            if (diff < 0) {
                m_Rigidbody.AddForceAtPosition(Vector3.up * floatingPower * Mathf.Abs(diff), floaters[i].position, ForceMode.Force);
                floatersUnderwater += 1;

                if (!isUnderwater) {
                    isUnderwater = true;
                    SwitchState(true);
                }
            }
        }

        if (isUnderwater && floatersUnderwater == 0) {
            isUnderwater = false;
            SwitchState(false);
        }
    }

    void SwitchState(bool isUnderwater) {
        if (isUnderwater) {
            m_Rigidbody.drag = underwaterDrag;
            m_Rigidbody.angularDrag = underwaterAngularDrag;
        } else {
            m_Rigidbody.drag = airDrag;
            m_Rigidbody.angularDrag = airAngularDrag;
        }
    }
}
