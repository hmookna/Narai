using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutScript_eng : MonoBehaviour {

    bool launchedApp;

	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2Menu_eng");
	}

    public void OnBackToHome(){
       SceneManager.LoadScene ("2Menu_eng");
    }

	// If switched app, set to true so it won't launch the browser
	void OnApplicationPause()
	{
		launchedApp = true;
	}

	IEnumerator CheckApp()
	{
		// Wait for a time
		yield return new WaitForSeconds (10);

		// If app hasn't launched, default to opening in browser
		if(!launchedApp)
		{
			Application.OpenURL ("http://www.finearts.go.th/somdetphranaraimuseum/");
		}
	}

	public void OpenMapProvince(){

		Application.OpenURL ("https://www.google.co.th/maps/place/Lop+Buri/@14.7986127,100.6130976,17z/data=!3m1!4b1!4m5!3m4!1s0x30e1ffe348676511:0xed24bbe98c64451e!8m2!3d14.7986127!4d100.6152863");

		// Do a check to see if they have the app installed
		StartCoroutine(CheckApp());
		launchedApp = false;
	}

	public void OpenMapMuseum(){

		Application.OpenURL ("https://www.google.co.th/maps/place/National+Museum+King+Narai/@14.7999879,100.6076369,17z/data=!3m1!4b1!4m5!3m4!1s0x30e1ffe56b3501a9:0x63cb6894e4c2713e!8m2!3d14.7999879!4d100.6098256");

		// Do a check to see if they have the app installed
		StartCoroutine(CheckApp());
		launchedApp = false;

	}

	public void OpenWebProvince(){
		Application.OpenURL ("http://www.lopburi.go.th");
//		Application.OpenURL ("https://youtube.com/user/hmookna");

		// Do a check to see if they have the app installed
		StartCoroutine(CheckApp());
		launchedApp = false;
	}

	public void OpenWebMuseum(){
		Application.OpenURL ("http://www.finearts.go.th/somdetphranaraimuseum/");

		// Do a check to see if they have the app installed
		StartCoroutine(CheckApp());
		launchedApp = false;
	}

	public void makePhoneCallProvince(){
		Application.OpenURL ("tel:+036770150");

		// Do a check to see if they have the app installed
		StartCoroutine(CheckApp());
		launchedApp = false;
	}

	public void makePhoneCallMuseum(){
		Application.OpenURL ("tel:+036770177");

		// Do a check to see if they have the app installed
		StartCoroutine(CheckApp());
		launchedApp = false;
	}
}
