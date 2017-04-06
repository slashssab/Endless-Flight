using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segment_creator : MonoBehaviour {
	public GameObject segment1;
	public GameObject segment2;
	public GameObject segment3;
	GameObject what_object;
	void random_segment()
	{
		int b = Random.Range (0, 3);
		if (b == 0) {
			what_object = segment1;
		}
		if (b == 1) {
			what_object = segment2;
		}
		if (b == 2) {
			what_object = segment3;
		}
		int a = Random.Range (0, 3);
		if (a == 0) {
			Instantiate(what_object,new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity); 
		}
		if (a == 1) {
			Instantiate(what_object,new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity); 		
		}
		if (a == 2) {
			Instantiate(what_object,new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity); 		
		}
	}
	// Use this for initialization
	void Start () {
		random_segment ();
		Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
