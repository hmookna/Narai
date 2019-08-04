using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FontScale : MonoBehaviour {

	public int fontSize;
	public int maxFontSize;
	public Sprite[] fontSprite;
	public GameObject btnChangeFont;
	public GameObject content_txt;
	public GameObject content_Panel;

	Vector2 initSize;
	int initFontSize;

	// Use this for initialization
	void Start () {
		RectTransform cp = content_Panel.transform as RectTransform;
		initSize = new Vector2( Screen.width, cp.sizeDelta.y);
		initFontSize = content_txt.GetComponent<Text>().fontSize;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void scaleFont(){

		if(fontSize >= maxFontSize-1){
			fontSize = 0;
		}else{
			fontSize++;
		}

		btnChangeFont.GetComponent<Image>().sprite = fontSprite[fontSize];

		RectTransform cp = content_Panel.transform as RectTransform;
		switch(fontSize){
		case 1: 
			//btnChangeFont.transform.localScale = new Vector2 (1.5f, 1.5f);
			cp.sizeDelta = new Vector2( 800, initSize.y + 500f);
			break;
		case 2: 
			//btnChangeFont.transform.localScale = new Vector2 (1.5f, 1.5f);
			cp.sizeDelta = new Vector2( 800, initSize.y + 1500f);
			break;
		default:
			//btnChangeFont.transform.localScale = new Vector2 (1f, 1f);
			cp.sizeDelta = new Vector2( 800, initSize.y);
			break;
		}

		cp.localPosition = new Vector2(0, -cp.sizeDelta.y/2);
		content_txt.GetComponent<Text>().fontSize = initFontSize + (fontSize*15);

	}
}




