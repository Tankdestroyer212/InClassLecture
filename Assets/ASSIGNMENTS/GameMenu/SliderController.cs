using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sliderText = null;
    [SerializeField] private float maxSliderAmount = 100.0f;

    public void SliderChange(float amount)
    {
        float localValue = amount * maxSliderAmount;
        sliderText.text = localValue.ToString("0");
    }
}
