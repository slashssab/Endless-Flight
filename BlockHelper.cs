using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHelper : MonoBehaviour {

    float b;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Vector3 GetBlockPosition()
    {      
        int a = (int)Random.Range(0, 3);       
        if (a == 0)
        {
            b = 2.5f;
        }
        else if (a == 1)
        {
            b = 0;
        }
        else if (a == 2)
        {
            b = -2.5f;
        }
        return new Vector3(b,0.5f,60);
    }
}
