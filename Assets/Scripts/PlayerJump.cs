using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class PlayerJump : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField] private float jumpHeight = 5.0f;
    private bool jumpPressed = false;
    private float gravityValue = -9.81f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // OnJump();
        JumpMovement();
    }

    void JumpMovement()
    {
        groundedPlayer = characterController.isGrounded;
        if (groundedPlayer)
        {
            playerVelocity.y = 0.0f;
        }
        if(jumpPressed && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -1.0f * gravityValue);
            jumpPressed = false;
        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        characterController.Move(playerVelocity * Time.deltaTime);
    }

    void OnJump()
    {
        Debug.Log("Jump pressed");
        if(characterController.velocity.y == 0)
        {
            Debug.Log("Can jump");
            jumpPressed = true;
        } else
        {
            Debug.Log("Cannot jump");
        }
    }
}
