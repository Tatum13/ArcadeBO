using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StanimaBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxStanime(int stanima)
    {
        slider.maxValue = stanima;
        slider.value = stanima;
    }
    
    public void SetStanima(int stanima)
    {
        slider.value = stanima;
    }
}
