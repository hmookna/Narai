using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangingImages : MonoBehaviour {
	public Sprite[] images;
	public GameObject content_img;
	public int current = 0;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeImage(int direction){
		current = current + direction;
		if(current < 0){
			current = images.Length -1;
		}
		else if (current >= images.Length){
			current = 0;
		}


		content_img.GetComponent<Image>().sprite = images[current];
	}
}


