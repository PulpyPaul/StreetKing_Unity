using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Item : MonoBehaviour {

	string name;

	int cost;
	int sellHigh;
	int sellLow;

    float totalTime;
    
	bool isCustom;

	Guid id;

	public Item(int cost, int sellHigh, int sellLow, float totalTime){
		this.cost = cost;
		this.sellHigh = sellHigh;
		this.sellLow = sellLow;
        this.totalTime = totalTime;
		id = Guid.NewGuid ();
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

	public Guid ID {
		get { 
			return id;
		}
	}
}
