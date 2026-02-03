using UnityEngine;
using TMPro;

public class FullscreenToggle : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Fullscreen_Change = null;

    public void FullscreenOptions(bool fullscreen)
    {
        if (Screen.fullScreen = fullscreen)
        {
            Fullscreen_Change.text = "Fullscreen";
        }

        else
        {
            Fullscreen_Change.text = "Windowed";
        }
    }
}
