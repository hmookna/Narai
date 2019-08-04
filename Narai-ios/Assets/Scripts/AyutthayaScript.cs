﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AyutthayaScript : MonoBehaviour {

    void Start(){
		PlayerPrefs.SetString("current scene", "2.3-2-2.4");
	}

    public void OnBackToHome(){
		SceneManager.LoadScene ("2Menu");
	}

	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2.3-2-2");
	}

    public void OnPushTo1(){
		PlayerPrefs.SetInt("QR Result", 37);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo2(){
		PlayerPrefs.SetInt("QR Result", 36);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo3(){
		PlayerPrefs.SetInt("QR Result", 38);
		SceneManager.LoadScene ("2.3N_Description");
	}
}
