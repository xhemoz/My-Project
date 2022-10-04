using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    UI_Methods resetGame;
    GameObject player;
    private void Start()
    {
        resetGame = GameObject.Find("UI Manager").GetComponent<UI_Methods>();
        player = GetComponent<GameObject>();
    }
    public void OnDeath()
    {
        resetGame.StartGame();
    }
}
