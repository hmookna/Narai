using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundAR : MonoBehaviour {

	public AudioSource audioData;

	void Start()
	{
		audioData = GetComponent<AudioSource>();
	}

	void Update(){

		if(GetComponent<SpriteRenderer>().enabled && !audioData.isPlaying){
			audioData.Play(0);
			Debug.Log("started");
		}

		else if(!GetComponent<SpriteRenderer>().enabled){
			audioData.Stop();
			Debug.Log("stopped");
		}
	}
}
