using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private Camera cam;
    private float dashSpeed = 250f;
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
        float moveX = Input.GetAxis("Horizontal") * dashSpeed;
        float moveZ = Input.GetAxis("Vertical") * dashSpeed;

        Vector3 moveDir =(transform.forward * moveZ) + (transform.right * moveX);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //controller.Move(moveDir * Time.deltaTime);
            controller.Move(moveDir * Time.deltaTime);
        }
    }
}
