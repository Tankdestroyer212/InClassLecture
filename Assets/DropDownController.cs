using UnityEngine;
using TMPro;

public class DropDownController : MonoBehaviour
{
    [SerializeField] private TMP_Text FullscreenText;

    public void DropdownOptions(int index)
    {
        switch (index)
        {
            case 0: FullscreenText.text = "4K"; break;
            case 1: FullscreenText.text = "HD"; break;
            case 2: FullscreenText.text = "Low Res"; break;
        }
    }
}
