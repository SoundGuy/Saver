using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Logic : MonoBehaviour {

	public RectTransform [] Kids;
	static int i=0;
	static int KidsSaved=0;
	public string [] KidNames;

	public Sprite [] sprites;

	public Text kidnameText;
	public Image kidImage;

	// Use this for initialization
	void Start () {


		if (Application.loadedLevelName == "ThankYou"||
		    Application.loadedLevelName == "Congratulations") {
			kidnameText.text = KidNames[i] + "?";
		}


		if ( Application.loadedLevelName == "Congratulations") {
			kidImage.sprite = sprites[i];
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

		if (i == 5) {
			i=0;
			foreach (RectTransform k in Kids) {
				k.GetComponent<Animator>().Play("MoveImage");
			}

		}
	}

	public void ClickStart() {
		Application.LoadLevel ("MainScene");
	}

	public void ClickSave() {
		Application.LoadLevel ("Saving");
	}

	
	public void ClickOK() {
		//Application.Quit(); 
			Application.LoadLevel ("NowDoSomething");
	}

	public void ClickQuit() {
			Application.Quit(); 

	}

	
	public void ClickShare() {
		Application.OpenURL ("http://www.facebook.com/share.php?u=http://smarturl.it/Saverr");
		
	}

}
