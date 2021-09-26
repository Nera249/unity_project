using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool JumpKeyPressed;
    private bool ZKeyPressed;
    private bool QKeyPressed;
    private bool SKeyPressed;
    private bool DKeyPressed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))                //Debug.Log("Space Key Pressed");           
        {
            JumpKeyPressed = true;
        } else {
            JumpKeyPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.Z))                           
        {
            ZKeyPressed = true;
        } else {
            ZKeyPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.Q))                           
        {
            QKeyPressed = true;
        } else {
            QKeyPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.S))                           
        {
            SKeyPressed = true;
        } else {
            SKeyPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.D))                           
        {
            DKeyPressed = true;
        } else {
            DKeyPressed = false;
        }

    }

    // FixedUpdate is called once every phisyc update 
    private void FixedUpdate()
    {
        if (JumpKeyPressed)                //Debug.Log("Space Key Pressed");           
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
