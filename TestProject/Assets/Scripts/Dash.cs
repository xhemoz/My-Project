using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private Camera cam;
    private float dashLength = 1000f;
    private CharacterController controller;
    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            controller.Move(transform.forward * dashLength * Time.deltaTime);
        }
    }
}
