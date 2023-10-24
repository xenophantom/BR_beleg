using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLava : MonoBehaviour
{
    public GameObject LavaPrefab1; 
    public GameObject LavaPrefab2; 
    public GameObject LavaPrefab3; 
    public int LavaCount = 3;
    public Vector3 spawnArea = new Vector3(100f, 0f, 20f);
    public float spawnInterval = 1f;
    private float timer = 0f;
    public float despawnDistance = 100f;

    void Start()
    {
        //GenerateLava();        
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            GenerateLava();
            timer = 0f;
        }
    }

    void GenerateLava()
    {
        int randomIndex = Random.Range(1, 4);
        GameObject selectedObject = null;

        switch (randomIndex)
        {
            case 1:
                selectedObject = LavaPrefab1;
                break;
            case 2:
                selectedObject = LavaPrefab2;
                break;
            case 3:
                selectedObject = LavaPrefab3;
                break;
        }

        if (selectedObject != null)
        {
            for (int i = 0; i < LavaCount; i++)
            {
                // Zufällige Position innerhalb des Spawn-Bereichs generieren
                Vector3 randomPosition = new Vector3(
                    Random.Range(0f, spawnArea.x),
                    Random.Range(0f, spawnArea.y),
                    Random.Range(100f, 100f)
                );

                // Skalierungsfaktor
                float scaleFactor = 3f;

                // Lava erzeugen und positionieren
                GameObject Lava = Instantiate(selectedObject, randomPosition, Quaternion.Euler(0f, 0f, 0f));
                Lava.transform.localScale *= scaleFactor;

                // Lava mit Skript zum Verfolgen der Entfernung versehen
                LavaDistanceTracker distanceTracker = Lava.AddComponent<LavaDistanceTracker>();
                distanceTracker.startPosition = randomPosition;
                distanceTracker.despawnDistance = despawnDistance;
            }
        }
    }
}