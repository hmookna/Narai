using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Menu2Script : MonoBehaviour {

    void Start(){
    	PlayerPrefs.SetString("current scene", "2Menu");
    }

	public void OnBackToFirstPage(){
		SceneManager.LoadScene ("1Main");
	}

	public void onPushToARScanner(){
		SceneManager.LoadScene ("2.1_before");

	}

	public void onPushToQRScanner(){
		SceneManager.LoadScene ("2.2_before");

	}

	public void onPushToAncient(){
		SceneManager.LoadScene ("2.3-1Ancient");

	}

	public void onPushToAntique(){
    	SceneManager.LoadScene ("2.3-2Antique");

    }

	public void onPushToVDO(){
		SceneManager.LoadScene ("2.5_VDO");

	}

	public void onPushToAbout(){
		SceneManager.LoadScene ("2.6About");
	}

	public void onPushToSetting(){
		SceneManager.LoadScene ("2.7Language");
	}


}
