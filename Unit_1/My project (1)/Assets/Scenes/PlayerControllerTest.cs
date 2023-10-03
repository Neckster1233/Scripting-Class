using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;
	[SerializeField] private float height = 6.3f;
    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping = false;
    private float horizontalInput = 5f;
    private float verticalInput = 5f;
	private bool isCrouching = false;
	private bool isSpringting = false;
	private bool isRotating = false;
    void Start()
    {
        GetComponent<CharacterController>();
    }

    void Update()
    {
        Input.GetAxis("Horizontal");
        Input.GetAxis("Veritcal");
        horizontalInput * moveSpeed = speedOfMovement;
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
		Input.GetButtonDown("Crouch");
		if (Input.GetButtonDown("Crouch") && controller.isGrounded)
			{
			isCrouching = true;
			}
		if (isJumping = false && isCrouching = true)
			{
			private float height = 3.15f;
			}
		Input.GetButtonDown("Sprint");
		if (isSprinting = true)
			{
			speedOfMovement * 2
			}
		Inpute.GetButtonDown("Rotate");
		if (isRotating = true)
			{
			horizontalInput = "Rotate"
			}
		
	}
}
