using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healtbar : MonoBehaviour
{

    public Slider slider;//slider

    public void SetMaxHealth(int health)//hier mee kan de script de slider in unity naar max healt zetten
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)//slider gedeelte
    {
        slider.value = health;
    }

}
