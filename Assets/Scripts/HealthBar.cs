using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    [Header("Reference to Health")]
    // Player's maximum health
    public float maxHealth;
    // Player's current health
    public float curHealth;
    [Header("Reference to UI Elements")]
    public Slider healthSlider;
    // Reference to fill
    public Image healthFill;


    void Update()
    {
        // Player death trigger
        healthSlider.value = Mathf.Clamp01(curHealth / maxHealth);
        if (curHealth <= 0 && healthFill.enabled)
        {
            Debug.Log("Dead");
            healthFill.enabled = false;
        }
        // Player revive trigger
        else if (!healthFill.enabled && curHealth > 0)
        {
            Debug.Log("Revive");
            healthFill.enabled = enabled;
        }
    }
}
