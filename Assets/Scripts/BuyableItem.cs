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
        float timeToGet = 0.0f;
		
		foreach (Text text in subTexts) {
			if (text.name == "Cost") {
				cost = int.Parse(text.text.Substring (1));
				break;
			}

            if (text.name == "Time") {
                int stringLength = text.text.Length;
                string timeString = text.text.Substring(0, text.text.Length - 1);
                string timeType = text.text.Substring(text.text.Length - 1);

                timeToGet = float.Parse(timeString);

                switch (timeType) {
                    case "s":
                        break;
                    case "m":
                        timeToGet = (timeToGet * 60);
                        break;
                    case "h":
                        timeToGet = (timeToGet * 60 * 60);
                        break;
                    default:
                        break;

                }
                
            }
		}

		// checks funds to see if user can purchase
		if (MoneyManager.instance.CheckFunds (cost)) {
			MoneyManager.instance.RemoveFunds (cost);

            Item item = new Item (cost, cost * 5, cost * 10, timeToGet);
            InventoryManager.instance.purchasedItems.Add(item);
            UIManager.instance.AddPurchasedItem(item);
			//Destroy (button.gameObject);
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
