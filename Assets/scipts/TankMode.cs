using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTankMode : MonoBehaviour
{
    public float SpeedInMeterPerSecond = 6.0f;
    public float RotationSpeedInDegreePerSecond = 180.0f;
    public float _jumpHeight = 0.5f;

    public GameObject _playerVisual;

    private CharacterController _characterController;
    private Vector3 _playerVelocity;
    private float _gravityValue = -9.81f;
    private bool _groundedPlayer = true;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        //https://docs.unity3d.com/ScriptReference/CharacterController.Move.html
        _groundedPlayer = _characterController.isGrounded;
        if (_groundedPlayer && _playerVelocity.y < 0)
        {
            _playerVelocity.y = 0f;
        }

        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * (RotationSpeedInDegreePerSecond * Time.deltaTime));

        _characterController.Move(transform.forward * Input.GetAxis("Vertical") * (SpeedInMeterPerSecond * Time.deltaTime));

        if (Input.GetKeyDown(KeyCode.Space) && _groundedPlayer)
        {
            _playerVelocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * _gravityValue);
        }
        _playerVelocity.y += _gravityValue * Time.deltaTime;
        _characterController.Move(_playerVelocity * Time.deltaTime);

        if ((Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.W)))
        {
            _playerVisual.GetComponent<Animator>().SetTrigger("Forward");
        }
        else if ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.A)))
        {
            _playerVisual.GetComponent<Animator>().SetTrigger("Left");
        }
        else if ((Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.D)))
        {
            _playerVisual.GetComponent<Animator>().SetTrigger("Right");
        }
        else if ((Input.GetKey(KeyCode.DownArrow)) || (Input.GetKey(KeyCode.S)))
        {
            _playerVisual.GetComponent<Animator>().SetTrigger("Backward");
        }
        else
        {
            _playerVisual.GetComponent<Animator>().SetTrigger("Idle");
            _playerVisual.GetComponent<Animator>().ResetTrigger("Forward");
            _playerVisual.GetComponent<Animator>().ResetTrigger("Backward");
            _playerVisual.GetComponent<Animator>().ResetTrigger("Right");
            _playerVisual.GetComponent<Animator>().ResetTrigger("Left");
        }
    }
}
