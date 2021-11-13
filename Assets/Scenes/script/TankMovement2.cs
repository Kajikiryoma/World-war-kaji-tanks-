using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement2 : MonoBehaviour
{
    public int playerNumber;

    public float moveSpeed;
    public float turnSpeed;
    private Rigidbody rb;
    private float movementInputValue;
    private float turnInputValue;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Turn();
    }

    void Move()
    {
        movementInputValue = Input.GetAxis("Vertical" + playerNumber);

        Vector3 movement = transform.forward * movementInputValue * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    void Turn()
    {
        turnInputValue = Input.GetAxis("Horizontal" + playerNumber);

        float turn = turnInputValue * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0, turn, 0);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}