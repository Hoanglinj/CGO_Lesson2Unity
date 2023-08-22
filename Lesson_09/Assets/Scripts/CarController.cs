using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private WheelCollider frontLeftWheel;
    [SerializeField] private WheelCollider frontRightWheel;
    [SerializeField] private WheelCollider rearLeftWheel;
    [SerializeField] private WheelCollider rearRightWheel;

    [SerializeField] private float maxSteerAngle = 30f; 

    [SerializeField] private float motorForce = 1500f; 

    [SerializeField] private float brakeForce = 3000f;

    
    void Update()
    {

        
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertial = Input.GetAxis("Vertical");

        
        float steerAngle = maxSteerAngle * inputHorizontal;

        

        float force = motorForce * inputVertial;

        frontLeftWheel.steerAngle = steerAngle;
        frontRightWheel.steerAngle = steerAngle;

        rearLeftWheel.motorTorque = force;
        rearRightWheel.motorTorque = force;

        if (Input.GetKey(KeyCode.Space))
        {
            frontLeftWheel.brakeTorque = brakeForce;
            frontRightWheel.brakeTorque = brakeForce;
            rearLeftWheel.brakeTorque = brakeForce;
            rearRightWheel.brakeTorque = brakeForce;
        }
        else
        {
            frontLeftWheel.brakeTorque = 0f;
            frontRightWheel.brakeTorque = 0f;
            rearLeftWheel.brakeTorque = 0f;
            rearRightWheel.brakeTorque = 0f;
        }
    }
}
