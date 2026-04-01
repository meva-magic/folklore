using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 velocity;
    public float speed = 5f;
    
    private Vector2 moveInput;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        
        ProcessMove(moveInput);
    }

    public void ProcessMove(Vector2 input)
    {
        if (controller == null) return;
        
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        
        Vector3 worldMove = transform.TransformDirection(moveDirection);
        
        controller.Move(worldMove * speed * Time.deltaTime);
    }
}