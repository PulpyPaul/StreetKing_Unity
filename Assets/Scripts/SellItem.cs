using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellItem : MonoBehaviour {

	Button[] priceButtons;

	Guid itemID;

	// Use this for initialization
	void Start () {

		priceButtons = this.GetComponentsInChildren<Button> ();

		foreach (Button button in priceButtons) {
			button.onClick.AddListener (() => Purchased(button));
		}
	}

	void Purchased(Button button) {
		
		// Adds funds to total money
		MoneyManager.instance.AddFunds (int.Parse(button.GetComponentInChildren<Text> ().text));

		// Removes the specific item from the inventory
		foreach (Item item in InventoryManager.instance.inventory) {
			if (item.ID == button.transform.parent.gameObject.GetComponent<SellItem> ().itemID) {
				InventoryManager.instance.inventory.Remove (item);
				break;
			}
		}

		// Removes object from UI list
		UIManager.instance.sellItems.Remove (button.transform.parent.gameObject);

		// Destroys the object
		Destroy (button.transform.parent.gameObject);
	}

	public Guid ItemID {
		get { 
			return itemID;
		}
		set { 
			itemID = value;
		}
	}


}
