using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Menu2Script_eng : MonoBehaviour {

    void Start(){
    	PlayerPrefs.SetString("current scene", "2Menu_eng");
    }

	public void OnBackToFirstPage(){
		SceneManager.LoadScene ("1Main");
	}

	public void onPushToARScanner(){
//		SceneManager.LoadScene ("2.3-2-2.4_eng");
		SceneManager.LoadScene ("2.1_before_eng");
	}

	public void onPushToQRScanner(){
		SceneManager.LoadScene ("2.2_before_eng");

	}

	public void onPushToAncient(){
		SceneManager.LoadScene ("2.3-1Ancient_eng");

	}

	public void onPushToAntique(){
    	SceneManager.LoadScene ("2.3-2Antique_eng");

    }

	public void onPushToVDO(){
		SceneManager.LoadScene ("2.5_VDO");

	}

	public void onPushToAbout(){
		SceneManager.LoadScene ("2.6About_eng");
	}
}
