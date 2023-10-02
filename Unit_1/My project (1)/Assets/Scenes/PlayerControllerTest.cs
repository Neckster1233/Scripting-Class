using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping = false;
    private float horizontalInput = 5f;
    private float verticalInput = 5f;
    void Start()
    {
        GetComponent<CharacterController>();
    }

    void Update()
    {
        Input.GetAxis("Horizontal");
        Input.GetAxis("Veritcal");
        horizontalInput* moveSpeed = speedOfMovement;
        Input.GetButtonDown("Jump");
        isJumping = true;
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            isJumping = true;
        }

        moveDirection.y - (gravity * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);
        //if jumping here
        if (isJumping = true)
        {
            moveDirection.y = jumpForce;
            isJumping = false;
        }

    }

}
