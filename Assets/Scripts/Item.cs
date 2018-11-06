using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Item : MonoBehaviour {

	string name;
	string timeString;

	int cost;
	int sellHigh;
	int sellLow;

    float totalTime;
	float timeLeft;
    
	bool isCustom;

	Guid id;

	public Item(int cost, int sellHigh, int sellLow, string timeString){
		this.cost = cost;
		this.sellHigh = sellHigh;
		this.sellLow = sellLow;
		this.timeString = timeString;
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

	public float TotalTime {
		get { 
			return totalTime;
		}
	}

	public float TimeLeft {
		get {
			return timeLeft;
		}
		set { 
			timeLeft = value;
		}
	}

	public string TimeString {
		get { 
			return timeString;
		}
	}

	public Guid ID {
		get { 
			return id;
		}
	}
}
