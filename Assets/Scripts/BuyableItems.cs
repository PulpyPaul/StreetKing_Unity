using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyableItems : MonoBehaviour {

	List<Item> itemList;

	// Use this for initialization
	void Start () {
		itemList = new List<Item> ();
		CreateTestItems ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CreateTestItems() {
		Item item1 = new Item (100, 500, 200);
		itemList.Add (item1);
	}
}
