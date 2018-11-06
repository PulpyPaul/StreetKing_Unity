using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchasedItem : MonoBehaviour {

	Guid id;

	float seconds;
	int minutes;
	int hours;

	bool updateTimer;

	Item currItem;

	// Use this for initialization
	void Start () {
		updateTimer = false;
	}

	public void StartTimer(Item item) {
		currItem = item;

		string timeString = item.TimeString;

		string[] times = timeString.Split (null);

		foreach (string timeValue in times) {
			if (timeValue.Contains ("s")) {
				seconds = float.Parse (timeValue.Substring (0, timeValue.Length - 1));
			} else if (timeValue.Contains ("m")) {
				minutes = int.Parse (timeValue.Substring (0, timeValue.Length - 1));
			} else if (timeValue.Contains ("h")) {
				hours = int.Parse (timeValue.Substring (0, timeValue.Length - 1));
			}
		}

		InvokeRepeating ("UpdateTimer", 0.0f, 1.0f / 60.0f);
	}

	void UpdateTimeUI() {
		Text[] texts = this.GetComponentsInChildren<Text> ();

		foreach (Text objTexts in texts) {
			if (objTexts.name == "Timer") {
				objTexts.text = hours+ "h " +minutes+ "m " +(int)seconds+ "s ";
				return;
			}
		}
	}

	void UpdateTimer() {
		if (hours <= 0 && minutes <= 0 && seconds <= 0) {
			CancelInvoke ();
			InventoryManager.instance.inventory.Add (currItem);
			UIManager.instance.purchasedItems.Remove (this.gameObject);
			Destroy (this.gameObject);
			return;
		}

		seconds -= Time.deltaTime;

		if (seconds <= 0 && minutes > 0) {
			minutes -= 1;
			seconds = 60;
		}

		if (minutes <= 0 && hours > 0) {
			hours -= 1;
			minutes = 60;
		}

		UpdateTimeUI ();
	}

	public Guid ID {
		get { 
			return id;
		}
		set { 
			ID = value;
		}
	}
}
