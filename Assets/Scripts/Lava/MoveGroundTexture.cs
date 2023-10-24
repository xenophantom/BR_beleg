using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGroundTexture : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    Renderer render;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveThisOne = Time.time * scrollSpeed;
        render.material.SetTextureOffset("_MainTex", new Vector2(moveThisOne, 0));
    }
}