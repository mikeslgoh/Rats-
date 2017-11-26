using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]

public class playaudio : MonoBehaviour {
    public AudioClip squish;
    private AudioSource source;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	
        void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            source.PlayOneShot(squish);
        }
    }
    
}
