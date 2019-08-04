using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeforeAR : MonoBehaviour {

    void Start(){
        PlayerPrefs.SetString("current scene", "2.1_before");
    }

	public void OnBackToHome(){
    	SceneManager.LoadScene ("2Menu");
    }

    public void onPushToARScanner(){
    	SceneManager.LoadScene ("2.1_AR_Scanner");
    }
}
