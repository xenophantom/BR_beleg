using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateIce : MonoBehaviour
{
    public GameObject IcePrefab1;
    public GameObject IcePrefab2;
    public GameObject IcePrefab3;
    public GameObject RotationMeer;
    public int IceCount = 3;
    public float spawnInterval = 1f;
    private float timer = 0f;
    public float despawnDistance = 10f;
    public float spawnDistance;
    public float spawnHeight = -10f;

    void Start()
    {
        //GenerateIce();        
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            GenerateIce();
            timer = 0f;
        }
    }

    void GenerateIce()
    {
        int randomIndex = Random.Range(1, 4);
        GameObject selectedObject = null;

        switch (randomIndex)
        {
            case 1:
                selectedObject = IcePrefab1;
                break;
            case 2:
                selectedObject = IcePrefab2;
                break;
            case 3:
                selectedObject = IcePrefab3;
                break;
        }

        if (selectedObject != null)
        {
            for (int i = 0; i < IceCount; i++)
            {
                // Zuf�llige Position innerhalb des Spawn-Bereichs generieren
                Vector3 randomPosition = new Vector3(
                    -3.55f, 3.55f, Random.Range(-spawnDistance, spawnDistance + 1)
                );

                // Skalierungsfaktor
                float scaleFactor = 3f;

                // Ice erzeugen und positionieren
                GameObject Ice = Instantiate(selectedObject, randomPosition, Quaternion.Euler(0f, 0f, 45f));
                Ice.transform.localScale *= scaleFactor;
                Ice.transform.parent = RotationMeer.transform;
            }
        }
    }
}