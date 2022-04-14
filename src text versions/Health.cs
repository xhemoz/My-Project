using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 100;
    private int currHealth;

    public Health_Bar bar;
    private void Start()
    {
        currHealth = maxHealth;
    }
    public void TakeDamage(int damageAmmount)
    {
        currHealth -= damageAmmount;
        bar.UpdateHealthBar(currHealth, maxHealth);
        if (currHealth <= 0)
        {
            currHealth = 0;
            Destroy(gameObject);
        }

    }
}
