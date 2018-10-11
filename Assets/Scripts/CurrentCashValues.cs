using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentCashValues : MonoBehaviour {

	Text cashText;

	// Use this for initialization
	void OnEnable() {
		updateCash ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateCash() {
		cashText = this.GetComponent<Text> ();
		cashText.text = "Total Cash: $" +MoneyManager.instance.TotalMoney.ToString ();
	}
}
