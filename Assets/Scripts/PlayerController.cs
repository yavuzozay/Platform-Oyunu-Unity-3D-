using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour


{
    CharacterController characterController;
    [SerializeField] float speed;
    [SerializeField] float jump;
    [SerializeField] float verticalSpeed;
    [SerializeField] float horizontalSpeed;
    private float groundDistance = 0.02f;
    private float gravity = -9.81f;
    float mSpeedY = 0;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    void Update()
    {
        Move();

    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = 1;
        Vector3 movement = new Vector3(0, 0, z).normalized + new Vector3(x * horizontalSpeed, 0, 0);

        Vector3 verticalMovement = Vector3.up * mSpeedY * Time.deltaTime;


        if (!characterController.isGrounded)
            mSpeedY += gravity * Time.deltaTime;
        else
            mSpeedY = 0;
        characterController.Move(verticalMovement + (movement * Time.deltaTime));
    }
}
