using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeforeAR_eng : MonoBehaviour {

    void Start(){
    	PlayerPrefs.SetString("current scene", "2.1_before_eng");
    }

	public void OnBackToHome(){
    	SceneManager.LoadScene ("2Menu_eng");
    }

    public void onPushToARScanner(){
    	SceneManager.LoadScene ("2.1_AR_Scanner");
    }
}
