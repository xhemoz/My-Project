using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance;
    [SerializeField]
    public TextMeshProUGUI killCounterUI;
    [HideInInspector]
    public int killCount;
    // Start is called before the first frame update
    void Awake()
    {
        killCount = 0;
        if (UI_Manager.instance == null)
        {
            instance = this;
        }
        else
            Destroy(gameObject);
    }
    public void UpdateKillCounter()
    {
        killCounterUI.text = "Kills:" + killCount.ToString();
    }
}
