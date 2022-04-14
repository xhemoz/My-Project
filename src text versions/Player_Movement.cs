using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Movement : MonoBehaviour
{
    public CharacterController controller;
    [SerializeField]
    private Transform groundCheck = null;
    private float moveSpeed = 12f;
    private float gravity = -9.81f;
    private float groundDist = 1f;
    private float jumpHeight = 5f;

    private bool isGrounded;

    public LayerMask groundMask;

    private Camera cam;

    Vector3 velocity;
    private void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDist, groundMask,QueryTriggerInteraction.Ignore);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -8;
        }

        Vector3 move = Quaternion.Euler(0,cam.transform.eulerAngles.y,0)*new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        controller.Move(move * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -3f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}