using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllManager : MonoBehaviour
{
    public int SlideSpeed;
    void Start()
    {
        
    }

    void FixedUpdate() 
    {
        if (Input.GetKey(KeyCode.A))
        {
          
            if (transform.position.x <= -2.5f)
            {
                transform.position = new Vector3(
                    -2.5f,
                    0.5f,
                    0);
            }
            else
            {
                transform.position = new Vector3(
                    transform.position.x - Time.deltaTime * SlideSpeed,
                    0.5f, 
                    0);
                
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            
            if (transform.position.x >= 2.5f)
            {
                transform.position = new Vector3(
                    2.5f, 
                    0.5f, 
                    0);
            }
            else 
            {
                transform.position = new Vector3(
                    transform.position.x + Time.deltaTime * SlideSpeed,
                    0.5f, 
                    0);
                
            }
        }

    }
    
}
