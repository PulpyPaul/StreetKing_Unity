using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	string name;

	int cost;
	int sellHigh;
	int sellLow;

	bool isCustom;

	public Item(int cost, int sellHigh, int sellLow){
		this.cost = cost;
		this.sellHigh = sellHigh;
		this.sellLow = sellLow;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CheckCustom() {
	
	}

	public int Cost {
		get {
			return cost;
		}
	}

	public int SellHigh {
		get {
			return sellHigh;
		}
	}

	public int SellLow {
		get {
			return sellLow;
		}
	}
}
