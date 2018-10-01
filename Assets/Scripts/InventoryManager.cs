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
