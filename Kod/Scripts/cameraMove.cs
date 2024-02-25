using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    [SerializeField] private Vector2 sensitivity;
    [SerializeField] private Vector2 acceleration;
    private Vector2 _rotation;
    private Vector2 _velocity;
    [SerializeField] private float maxVerticalAngleFromHorizon;
    [SerializeField] private float inputLagPeriod;

    private Vector2 _lastInputEvent;
    private float _inputLagTimer;

    float ClampVerticalAngle(float angle)
    {
        return Mathf.Clamp(angle, -maxVerticalAngleFromHorizon, maxVerticalAngleFromHorizon);
    }
    private Vector2 GetInput()
    {
        _inputLagTimer += Time.deltaTime;
        Vector2 input = new Vector2(Input.GetAxis("Mouse X"),
            Input.GetAxis("Mouse Y"));
        if ((Mathf.Approximately(0, input.x) && Mathf.Approximately(0, input.y)) == false ||
            _inputLagTimer >= inputLagPeriod)
        {
            _lastInputEvent = input;
            _inputLagTimer = 0;
        }
        
        return _lastInputEvent;
    }

    void Update()
    {
        float moveforwardbackward = Input.GetAxis("Vertical");
        float moveleftRight = Input.GetAxis("Horizontal");
            transform.position += new Vector3(moveleftRight * 10f *Time.deltaTime, 0, moveforwardbackward * 10f * Time.deltaTime);
        
        Vector2 wantedVelocity = GetInput() * sensitivity;

        _velocity = new Vector2(
            Mathf.MoveTowards(_velocity.x, wantedVelocity.x, acceleration.x * Time.deltaTime),
            Mathf.MoveTowards(_velocity.y, wantedVelocity.y, acceleration.y * Time.deltaTime));
        _rotation += _velocity * Time.deltaTime;
        _rotation.y = ClampVerticalAngle(_rotation.y);
        transform.localEulerAngles = new Vector3(_rotation.y, _rotation.x, 0);
    }
}
