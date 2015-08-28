using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CHageAfterLoad : MonoBehaviour {

	public Text SavingChild;
	public Text Scanning;
	// Use this for initialization
	void Start () {
	
		StartCoroutine(runAnims());
	}


	IEnumerator runAnims() {
		yield return new WaitForSeconds(1);
		SavingChild.text = "Saving Child.";
		yield return new WaitForSeconds(1);
		SavingChild.text = "Saving Child..";
		yield return new WaitForSeconds(1);
		SavingChild.text = "Saving Child...";
		Scanning.gameObject.SetActive (true);
		Scanning.enabled = true;
		yield return new WaitForSeconds(1);
		Scanning.text = "Scanning For Viruses.";
		yield return new WaitForSeconds(1);
		Scanning.text = "Scanning For Viruses..";
		yield return new WaitForSeconds(1);
		Scanning.text = "Scanning For Viruses...";
		Application.LoadLevel ("Congratulations");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
