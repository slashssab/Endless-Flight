using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon_script : MonoBehaviour {

    public float Radius;
    public GameObject Planet;
    public float Speed;
    private float angle=0;
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(
            Radius*Mathf.Sin(angle)+Planet.transform.position.x,
            Planet.transform.position.y,
            Radius * Mathf.Cos(angle)+Planet.transform.position.z);
        angle=angle+(float)Speed;
    }
}
