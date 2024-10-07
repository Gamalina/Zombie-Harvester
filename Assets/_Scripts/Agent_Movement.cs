using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class Agent_Movement : MonoBehaviour
{
    protected Rigidbody2D rigidbody2d;

    [field: SerializeField]
    public DataMovementSO MovementData { get; protected set; }

    [SerializeField]
    protected float currentVelocity = 1;
    protected Vector2 movementDirection;


    [field: SerializeField]
    protected UnityEvent<float> OnVelocityChange {get; set; }

    private void Awake()
    {
        rigidbody2d= GetComponent<Rigidbody2D>();
    }
    public void MoveAgent(Vector2 movementInput)
    {
        if (movementInput.magnitude > 0)
        {
            if (Vector2.Dot(movementInput.normalized, movementDirection) < 0)
                currentVelocity = 0;
            movementDirection = movementInput.normalized;
        }
        currentVelocity = CalculateSpeed(movementInput);

    }

    private float CalculateSpeed(Vector2 movementInput)
    {
        if(movementInput.magnitude > 0) 
        {
            currentVelocity += MovementData.acceleration * Time.deltaTime;
        }
        else
        {
            currentVelocity -= MovementData.deaccleration * Time.deltaTime;
        }
        return Math.Clamp(currentVelocity, 0, MovementData.maxSpeed);
    }

    private void FixedUpdate()
    {
        OnVelocityChange?.Invoke(currentVelocity);
        rigidbody2d.velocity = currentVelocity*movementDirection.normalized;
    }
}
