using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class HealthBar : MonoBehaviour
{
    //Healthbar slider
    public Slider slider;

    //Sets the max health for the healthbar
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    //When the healtbar changes the health is set
    public void SetHealth(int health)
    {
        slider.value = health;
    }

}
