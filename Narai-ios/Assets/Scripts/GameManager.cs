using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//public GameObject[] Prefab_ContentCanvas;
	public int selectedContent;

	GameObject MainContent;


	// Use this for initialization
	void Start () {
	Debug.Log("res = " + PlayerPrefs.GetInt("QR Result"));
//		PlayerPrefs.SetInt ("QR Result", 15);
		selectedContent = PlayerPrefs.GetInt("QR Result") ;

		//MainContent = Instantiate(Prefab_ContentCanvas[selectedContent-1], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
		//PlayerPrefs.SetInt("Language", 0);


		if (PlayerPrefs.GetInt("Language") == 1){ //ENG
			MainContent = Instantiate (Resources.Load("Canvas/English/" + selectedContent + "_ContentCanvas_eng", typeof(GameObject))) as GameObject;
		//	MainContent = Instantiate(Resources.Load("Canvas/English/" + selectedContent + "_ContentCanvas_eng") as GameObject, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
		}
		else { //THAI
          	MainContent = Instantiate (Resources.Load("Canvas/Thai/" + selectedContent + "_ContentCanvas", typeof(GameObject))) as GameObject;
          	//Instantiate(Resources.Load("Canvas/Thai/5_ContentCanvas ") as GameObject, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        }

		Debug.Log("selectedContent = " + selectedContent);

	}

	// Update is called once per frame
	void Update () {

	}
}
