using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drivingScript : MonoBehaviour
{

    public WheelJoint2D wheelBack, wheelFront;
    public float SpeedForward;

    public float SpeedBackward;
    public float Torque;

    private JointMotor2D backMotor, frontMotor;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if(x > 0)
        {
            backMotor.motorSpeed = SpeedForward;
            frontMotor.motorSpeed = SpeedForward;

            backMotor.maxMotorTorque = Torque;
            frontMotor.maxMotorTorque = Torque;

            wheelFront.motor = frontMotor;
            wheelBack.motor = backMotor;
        }
        else if(x < 0)
        {
            backMotor.motorSpeed = SpeedBackward;
            frontMotor.motorSpeed = SpeedBackward;

            backMotor.maxMotorTorque = Torque;
            frontMotor.maxMotorTorque = Torque;

            wheelFront.motor = frontMotor;
            wheelBack.motor = backMotor;
        } 
        else
        {
            backMotor.motorSpeed = 0;
            frontMotor.motorSpeed = 0;

            wheelFront.motor = frontMotor;
            wheelBack.motor = backMotor;
        }
    }
}
