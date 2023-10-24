using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickeventSingleplayer : MonoBehaviour
{
    public string sceneToLoad; // Name der Szene, die du laden möchtest

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(LoadScene);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
