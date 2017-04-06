using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Control : MonoBehaviour {
	public bool roads = false;
	public int speed = 10;
	public GameObject Segment;
	// Use this for initialization
	void Start () {
		if (roads == false) {
			Instantiate(Segment,new Vector3(0,0,38),Quaternion.identity); 
			Instantiate(Segment,new Vector3(0,0,30),Quaternion.identity); 
			Instantiate(Segment,new Vector3(0,0,22),Quaternion.identity); 
			Instantiate(Segment,new Vector3(0,0,14),Quaternion.identity);  
			Instantiate(Segment,new Vector3(0,0,6),Quaternion.identity);  
			Instantiate(Segment,new Vector3(0,0,-2),Quaternion.identity);  
			roads = true;
		}
	}

	public void set_health()
	{

	}
	// Update is called once per frame
	void Update () {
		
	}
}
