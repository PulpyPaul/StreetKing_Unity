using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

	public List<Item> inventory;
	public List<Item> buyableItems;
    public List<Item> purchasedItems;

	public static InventoryManager instance = null;

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		inventory = new List<Item> ();
	}

	// Use this for initialization
	void Start () {
		
	}

	public void StartCooldown() {
		
	}

	public void GenerateValues() {
	
	}
}
