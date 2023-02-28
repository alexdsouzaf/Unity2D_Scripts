using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBastao : MonoBehaviour
{

    public float speed = 1000000;
    public bool isTouched = false;
    public bool isPressed = false;

    
    private HingeJoint2D hingeJoint2D;
    private JointMotor2D jointMotor;


    // Start is called before the first frame update
    void Start()
    {
        hingeJoint2D = GetComponent<HingeJoint2D>();
        jointMotor = hingeJoint2D.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (this.hingeJoint2D != null)
            {
                this.hingeJoint2D.useMotor = true;
                this.jointMotor.motorSpeed = -speed;
                //var motor = this.hingeJoint2D.motor;
                //motor.motorSpeed = speed;
            }
        }

    }

    private void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    var hingeJoint = this.gameObject.GetComponent<HingeJoint2D>();
        //    if (hingeJoint != null)
        //    {
        //        hingeJoint.useMotor = !hingeJoint.useMotor;
        //        var motor = hingeJoint.motor;
        //        motor.motorSpeed = speed;
        //    }


        //    //if (hingeJoint.limitState == JointLimitState2D.LowerLimit)
        //    //{
        //    //    hingeJoint.useMotor = false;
        //    //}
        //}

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    jointMotor.motorSpeed = -speed;
        //    hingeJoint2D.motor = jointMotor;
        //}
        //else
        //{
        //    jointMotor.motorSpeed = speed;
        //    hingeJoint2D.motor = jointMotor;
        //}
    }
}
