using UnityEngine;

[SerializeField] private float moveSpeed = 5f;
[SerializeField] private float jumpForce = 5f;
[SerializeField] private float gravity = 9.81f;

private CharacterController controller;
private Vector3 moveDirection;
private bool isJumping;

void start()
{
    GetComponent<CharacterController>()
}

void Update()
{
    Input.GetAxis("Horizontal")
    Input.GetAxis("Veritcal")
    private float horizontalInput = 5f;
    private float verticalInput = 5f;
// Not sure if this part is correct
    horizontalInput * moveSpeed = speedOfMovement
    Input.GetButtonDown("Jump")
    CharacterController.isGrounded
    // Need to check if player is pressing jump here
    moveDirection.y - (gravity * Time.deltaTime)
    CharacterController.Move(moveDirection * Time.deltaTime)
    //if jumping here
    if isJumping = true
        moveDirection.y = jumpForce
}

