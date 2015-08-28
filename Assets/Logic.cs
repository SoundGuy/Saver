using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Logic : MonoBehaviour {

	public RectTransform [] Kids;
	static int i=0;
	static int KidsSaved=0;
	public string [] KidNames;

	public Text kidnameText;

	// Use this for initialization
	void Start () {


		if (Application.loadedLevelName == "ThankYou") {
			kidnameText.text = KidNames[i];
		}

		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); 
	
	}


	public void ClickYes() {
		Kids [i].GetComponent<Animator> ().Play ("MoveImage 1");
		KidsSaved = i;
		Application.LoadLevel ("ThankYou");
		//i++;

	}

	public void ClickNo() {
		Kids [i].GetComponent<Animator> ().Play ("MoveImage 2");
		i++;

	}

	public void ClickStart() {
		Application.LoadLevel ("MainScene");
	}
}
