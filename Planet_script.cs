using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_script : MonoBehaviour {

    public float Radius;
    private float angle=0;
    public float Speed;
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(
            Radius * Mathf.Sin(angle),
            Radius/2 * Mathf.Cos(angle),
            Radius/2 * Mathf.Cos(angle)+30);
        angle=angle+(float)Speed;
    }
}
