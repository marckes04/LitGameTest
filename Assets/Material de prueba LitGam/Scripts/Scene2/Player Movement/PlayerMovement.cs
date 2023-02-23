using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private CharacterController charController;
    private PlayerAnimations playAnim;

    public float movementSpeed = 3f;
    public float gravity = 9.8f;
    public float rotationSpeed = 0.15f;
    public float rotateDegreesPerSecond = 180f;


    void Awake() 
    {
        charController = GetComponent<CharacterController>();
        playAnim = GetComponent<PlayerAnimations>();
    }
    
    void Update()
    {
        Move();
        Rotate();
        WalkAnimation();
    }

    void Move()
    {
        if(Input.GetAxis(Axis.VERTICAL_AXIS) > 0)
        {
            Vector3 moveDirection = transform.forward;
            moveDirection.y -= gravity * Time.deltaTime;
            charController.Move(moveDirection * movementSpeed*Time.deltaTime);
        }

        else if(Input.GetAxis(Axis.VERTICAL_AXIS) < 0)
        {
            Vector3 moveDirection = -transform.forward;
            moveDirection.y -= gravity * Time.deltaTime;
            charController.Move(moveDirection * movementSpeed*Time.deltaTime);
        }

        else
        {
            charController.Move(Vector3.zero);
        }
    }

    void Rotate()
    {

        Vector3 rotationDirection = Vector3.zero;

        if(Input.GetAxis(Axis.HORIZONTAL_AXIS) < 0)
        {
        rotationDirection = transform.TransformDirection(Vector3.left);
        }

        else if(Input.GetAxis(Axis.HORIZONTAL_AXIS) > 0)
        {
            rotationDirection = transform.TransformDirection(Vector3.right);
        }

        if(rotationDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation, Quaternion.LookRotation(rotationDirection),
                rotateDegreesPerSecond*Time.deltaTime);
        }
    }

    void WalkAnimation()
    {
        if(charController.velocity.sqrMagnitude != 0f)
        {
            playAnim.Walk(true);
        }
        else
        {
            playAnim.Walk(false);
        }
    }
}
