using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{  
    
   private bool JumpKeyPressed;
   private float HorizontalInput;
   
    // Start is called before the first frame update
    void Start()
        {

        }

    // Update is called once per frame
    void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))                //Debug.Log("Space Key Pressed");           
                {
                   JumpKeyPressed = true;                    
                }
    
        }
    
    // FixedUpdate is called once every phisyc update 
    private void FixedUpdate()          
        {
             if (JumpKeyPressed)                //Debug.Log("Space Key Pressed");           
                {
                    GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);  
                    JumpKeyPressed = false;                    
                }   
        }
}
