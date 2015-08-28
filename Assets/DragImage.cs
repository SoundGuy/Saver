using UnityEngine;
using System.Collections;

public class DragImage : MonoBehaviour {

	bool touching;
	public Logic logic;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		Vector2 pos2 = GetComponent<RectTransform> ().anchoredPosition; 

		if (Input.touchCount >= 1) {

			Vector2 pos = Input.touches [0].position;
//			Debug.Log ("pos = " + pos + " (" + pos.x + "," + pos.y + ")" + GetComponent<RectTransform> ().anchoredPosition);


			pos2.x = pos.x - 400;

			if (Input.touches[0].phase == TouchPhase.Ended) {

				if (touching == false && pos.x > 600) {
					touching = true;
					logic.ClickYes();
				}
				if (touching == false && pos.x < 200) {
					touching = true;
					logic.ClickNo();
				}
			}

			if (touching) {
				pos2.x=0;
			}

		} else {
			pos2.x = 0;
			touching = false;
		}
	
		GetComponent<RectTransform> ().anchoredPosition = pos2; //Set(pos.x,GetComponent<RectTransform>().anchoredPosition.y);

	}
}
