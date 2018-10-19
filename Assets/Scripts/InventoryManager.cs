using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

	public List<Item> inventory;
	public List<Item> buyableItems;

	public static InventoryManager instance = null;

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		inventory = new List<Item> ();

		Item testItem1 = new Item (25, 200, 100);
		Item testItem2 = new Item (50, 400, 100);
		Item testItem3 = new Item (100, 600, 300);
		Item testItem4 = new Item (200, 800, 400);

		inventory.Add (testItem1);
		inventory.Add (testItem2);
		inventory.Add (testItem3);
		inventory.Add (testItem4);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddToInventory() {
	
	}

	public void RemoveFromInventory() {
		
	}

	public void StartCooldown() {
		
	}

	public void GenerateValues() {
	
	}
}
