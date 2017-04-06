using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_script : MonoBehaviour {

    public GameObject PickUp;
    public road_script Road;
	void Start () {
        PickUp.name = "PickUp";
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - Road.road_speed * Time.deltaTime);

      if (transform.position.z < -6f)
        {
            
                int a = Random.Range(0, 3);
                if (a == 0)
                {
                    Instantiate(PickUp, new Vector3(2.5f, 0.5f, 65), Quaternion.identity);
                }
                else if (a == 1)
                {
                    Instantiate(PickUp, new Vector3(0, 0.5f, 65), Quaternion.identity);
                }
                else if (a == 2)
                {
                    Instantiate(PickUp, new Vector3(-2.5f, 0.5f, 65), Quaternion.identity);
                }
                Destroy(gameObject);
            
        }
    }
}
