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

	public void updateCash() {
		cashText = this.GetComponent<Text> ();
		cashText.text = "Total Cash: $" +MoneyManager.instance.TotalMoney.ToString ();
	}
}
