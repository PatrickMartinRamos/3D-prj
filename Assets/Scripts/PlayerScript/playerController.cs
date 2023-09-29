using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class playerController : MonoBehaviour
{
    public playerStats player_KnightStats;
    private Vector2 playerMove;

    private playerAnimations knight_animation;

    public void Start()
    {

        knight_animation = GetComponentInChildren<playerAnimations>();
    }

    public void Update()
    {
        movePlayer();
        // Check if player is moving and call animation functions accordingly
        if (playerMove != Vector2.zero)
        {
            knight_animation.isStartWalking();
        }
        else
        {
            knight_animation.isStopWalking();
        }
    }
    public void movePlayer()
    {

        Vector3 playerMovement = new(playerMove.x, 0f, playerMove.y);

        if (playerMovement != Vector3.zero)
        {
            // Calculate the rotation angle based on the input direction.
            float targetRotationAngle = Mathf.Atan2(playerMovement.x, playerMovement.z) * Mathf.Rad2Deg;

            // Create a rotation quaternion based on the calculated angle.
            Quaternion targetRotation = Quaternion.Euler(0f, targetRotationAngle, 0f);

            // Rotate the player smoothly toward the target rotation.
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);
        }

        transform.Translate(playerMovement * player_KnightStats.moveSpeed * Time.deltaTime, Space.World);
    }

    public void onPlayerMove(InputAction.CallbackContext context)
    {
        playerMove = context.ReadValue<Vector2>();
    }

    void playerKnightAnim()
    {

    }
}
