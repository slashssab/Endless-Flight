using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road_script : MonoBehaviour {
    public int road_speed;
	public bool moving = true;
	public bool recreate = true;
    public GameObject Segment;
    private BlockHelper _BlockHelper;
    private GameObject Control;
	void Start ()
    {
        _BlockHelper = new BlockHelper();
		//znajduję skrypt Game_Control doczepiony do obiektu Game_control i pobieram prędkość
        //ConfigurationManager confMgr = ConfigurationManager.GetCurrent();
        //Control = GameObject.Find(confMgr.GameControl);
		Control = GameObject.Find("Game_control"); //
		Game_Control gamescript = Control.GetComponent<Game_Control> ();
		road_speed = gamescript.speed;
        
    }
		

	void Update () {
		if (moving == true) {
			transform.position = new Vector3 (
                transform.position.x,
                transform.position.y,
                transform.position.z - road_speed * Time.deltaTime);

			if (gameObject.transform.position.z < -6)
            {
				if (recreate == true) {
                    Vector3 blockPosition = _BlockHelper.GetBlockPosition();
                    Instantiate(Segment, blockPosition, Quaternion.identity);
      				Destroy (gameObject);
				}
            }
            
        }
	}
}
