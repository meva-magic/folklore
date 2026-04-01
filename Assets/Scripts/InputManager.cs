using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnFootAction onFoot;

    private PlayerMove playerMove;

    void Awake()
    {
        playerInput = new playerInput();

        onFoot = playerInput.onFoot;

        playerMove = GetComponent<PlayerMove>();
    }

    void FixedUpdate()
    {
        playerMove.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }
}
