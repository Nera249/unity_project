using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    private bool JumpKeyPressed;
    private bool ZKeyPressed;
    private bool QKeyPressed;
    private bool SKeyPressed;
    private bool DKeyPressed;
    private float HorizontalInput;
    private bool moving;
    private bool Yaxe;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))                //Debug.Log("Space Key Pressed");           
        {
            JumpKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))                           
        {
            JumpKeyPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.Z))                           
        {
            ZKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Z))                           
        {
            ZKeyPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.Q))                           
        {
            QKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Q))                           
        {
            QKeyPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.S))                           
        {
            SKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.S))                           
        {
            SKeyPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.D))                           
        {
            DKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.D))                           
        {
            DKeyPressed = false;
        }

    }

    // FixedUpdate is called once every phisyc update 
    private void FixedUpdate()
    {
        if (JumpKeyPressed && Yaxe<0.5)                //Debug.Log("Space Key Pressed");           
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 7, ForceMode.VelocityChange);
            JumpKeyPressed = false;
        }
        if (ZKeyPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 1, ForceMode.VelocityChange);

            if (Input.GetKeyUp(KeyCode.Z))
            {
                ZKeyPressed = false;
            }
        }
        if (QKeyPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 1, ForceMode.VelocityChange);

            if (Input.GetKeyUp(KeyCode.S))
            {
                QKeyPressed = false;
            }
        }
        if (SKeyPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 1, ForceMode.VelocityChange);

            if (Input.GetKeyUp(KeyCode.S))
            {
                SKeyPressed = false;
            }
        }
        if (DKeyPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 1, ForceMode.VelocityChange);

            if (Input.GetKeyUp(KeyCode.D))
            {
                DKeyPressed = false;
            }
        }

    }
}
