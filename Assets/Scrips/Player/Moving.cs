using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    [Header("Movement Speeds")]
    [SerializeField] private float _walkSpeed = 5.0f;

    [Header("Look Sensivity")]
    [SerializeField] private float _lookSensivity = 1.4f;
    [SerializeField] private float _upDownRange = 20f;

    [Header("Joysticks")]
    [SerializeField] private FixedJoystick _joystickCharacter;
    [SerializeField] private FixedJoystick _joystickCamera;

    private CharacterController _characterController;
    private bool isMoving;
    private float _verticalRotation;
    private Camera _mainCamera;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _mainCamera = Camera.main;

    }

    private void FixedUpdate()
    {
        if (!FinishManager._isFinish || GameDownCounter._gameCounting)
        {
            handleMovement();
            HandleRotation();
        }

    }

    private void handleMovement()
    {
        float verticalSpeed = _joystickCharacter.Vertical * _walkSpeed;
        float horizontalSpeed = _joystickCharacter.Horizontal * _walkSpeed;
        Vector3 speed = new Vector3(horizontalSpeed, 0, verticalSpeed);
        speed = transform.rotation * speed;
        _characterController.SimpleMove(speed);
        isMoving = verticalSpeed != 0 || horizontalSpeed != 0;
    }
    private void HandleRotation()
    {
        float joystickXrotation = _joystickCamera.Horizontal * _lookSensivity;
        transform.Rotate(0, joystickXrotation, 0);

        _verticalRotation -= _joystickCamera.Vertical * _lookSensivity;
        _verticalRotation = Mathf.Clamp(_verticalRotation, -_upDownRange, _upDownRange);
        _mainCamera.transform.localRotation = Quaternion.Euler(_verticalRotation, 0, 0);


    }
}
