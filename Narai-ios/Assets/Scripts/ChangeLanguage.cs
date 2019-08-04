using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour {
	public GameObject[] thaiOBJ;
	public GameObject[] engOBJ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("Language") == 1) { // 0 = Thai, 1 = English
			for(int i = 0; i < thaiOBJ.Length; i++){
				thaiOBJ [i].SetActive (false);
				engOBJ [i].SetActive (true);
			}
		} else {
			for(int i = 0; i < thaiOBJ.Length; i++){
				thaiOBJ [i].SetActive (true);
				engOBJ [i].SetActive (false);
			}
		}
	}
}
