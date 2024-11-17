using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpbar : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void SetMaxHP(int maxHealth)
    {
        slider.maxValue = maxHealth;
    }

    public void UpdateHealthBar(int currentHP)
    {
        slider.value = currentHP;
    }
}
