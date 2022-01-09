using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin_Collecting : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private int coinCounter = 0;

    private void Update()
    {
        coinText.text = "Coins:" + coinCounter;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            coinCounter += 1;
            Destroy(other.gameObject);
        }
    }
}
