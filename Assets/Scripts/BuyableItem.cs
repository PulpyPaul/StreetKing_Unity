using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyableItem : MonoBehaviour {

	Button purchaseBtn;

	Guid id;

	// Use this for initialization
	void Start () {
		SetupPurchaseBtn ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// Gets reference to the button and hooks up an onclick event
	/// </summary>
	void SetupPurchaseBtn() {
		purchaseBtn = GetComponent<Button> ();
		purchaseBtn.onClick.AddListener (() => Purchase(purchaseBtn));
	}

	/// <summary>
	/// Purchases the item and adds to inventory
	/// </summary>
	/// <param name="button">Button.</param>
	void Purchase(Button button) {
		Text[] subTexts = button.gameObject.GetComponentsInChildren<Text> ();

		int cost = 0;
		string timeString = "";
		
		foreach (Text text in subTexts) {
			if (text.name == "Cost") {
				cost = int.Parse(text.text.Substring (1));
			}

            if (text.name == "Time") {
				timeString = text.text;
            }
		}

		// checks funds to see if user can purchase and creates new item in the inventory
		if (MoneyManager.instance.CheckFunds (cost)) {
			MoneyManager.instance.RemoveFunds (cost);
			Item item = new Item (cost, (int)(cost * 1.2f), (int)(cost * 2.0f), timeString);
			InventoryManager.instance.purchasedItems.Add(item);
			UIManager.instance.AddPurchasedItem(item);
		} else {
			return;
		}
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
