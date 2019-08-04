using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContentScript : MonoBehaviour {

	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2Menu");
	}

	public void onPushToAncient(){
		
		SceneManager.LoadScene ("2.3-1Ancient");
	}

	public void onPushToAntique(){
		SceneManager.LoadScene ("2.3-2Antique");
	}
}
