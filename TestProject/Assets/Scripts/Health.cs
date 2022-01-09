using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    public const int maxHealth = 100;
    public int currHealth = maxHealth;
    public RectTransform healthBar;
    public void TakeDamage(int damageAmmount)
    {
        currHealth -= damageAmmount;

        if (currHealth <= 0)
        {
            currHealth = 0;
            Destroy(gameObject);
            UI_Manager.instance.killCount++;
            UI_Manager.instance.UpdateKillCounter();
        }

        healthBar.sizeDelta = new Vector2(currHealth * 2, healthBar.sizeDelta.y);
    }
}
