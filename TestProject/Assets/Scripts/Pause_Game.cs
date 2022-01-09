using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause_Game : MonoBehaviour
{
    private bool paused = false;
    public GameObject quitMenu;
    void Start()
    {
        quitMenu = GameObject.Find("QuitMenu");
        quitMenu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Cursor.lockState = CursorLockMode.Locked;
                quitMenu.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Confined;
                quitMenu.SetActive(true);
                Time.timeScale = 0f;
            }
            paused = !paused;
        }
    }
}