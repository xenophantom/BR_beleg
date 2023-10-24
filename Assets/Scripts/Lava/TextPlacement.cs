using UnityEngine;
using TMPro;

public class TextPlacement : MonoBehaviour
{
    public Camera mainCamera;
    public Canvas canvas;
    public TMP_Text textObject;

    void Update()
    {
        // Set the canvas position to the top-left corner of the camera
        canvas.transform.position = mainCamera.transform.position + mainCamera.transform.forward * 2f;
        canvas.transform.rotation = mainCamera.transform.rotation;

        // Set the text object position to the top-left corner of the canvas
        RectTransform canvasRect = canvas.GetComponent<RectTransform>();
        Vector2 canvasTopLeft = (Vector2)canvasRect.position - canvasRect.sizeDelta / 2f;
        textObject.rectTransform.anchoredPosition = canvasTopLeft;
    }
}
