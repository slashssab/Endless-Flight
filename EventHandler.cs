using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class EventHandler : MonoBehaviour {

    public AudioClip impact;
    AudioSource audio;
    public Text countText;
    public Text infoText;
    private int count;
    

    void Start()
    {
        count = 0;
        SetCountText();
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) //Event handler 
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
            count = count + 1;
            SetCountText();                   
        }
        if (other.gameObject.CompareTag("Wall"))
        {
            audio.PlayOneShot(impact, 0.7F);
            infoText.text = "You died";
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

}
