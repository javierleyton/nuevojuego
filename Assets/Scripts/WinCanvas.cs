using UnityEngine;

public class WinCanvas : MonoBehaviour
{
    public GameObject winCanvas;

    void Start()
    {
        // Disable the canvas initially
        winCanvas.SetActive(false);
    }

    public void ShowWinCanvas()
    {
        // Enable the canvas when called, only if it's not null
        if (winCanvas != null)
        {
            winCanvas.SetActive(true);
        }
    }

    public void HideWinCanvas()
    {
        // Disable the canvas, only if it's not null
        if (winCanvas != null)
        {
            winCanvas.SetActive(false);
        }
    }

    void OnDestroy()
    {
        // Show the win canvas when this object is destroyed, only if it's not null
        if (winCanvas != null)
        {
            ShowWinCanvas();
        }
    }
}