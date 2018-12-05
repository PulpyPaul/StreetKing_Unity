using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Item {

	string name;
	string timeString;

	int cost;
	int sellHigh;
	int sellLow;

    float totalTime;
	float timeLeft;
    
	bool isCustom;

	Guid id;

	public Item(int cost, int sellHigh, int sellLow, string timeString, string name){
		this.cost = cost;
		this.sellHigh = sellHigh;
		this.sellLow = sellLow;
		this.timeString = timeString;
		this.name = name;
        id = Guid.NewGuid ();
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

	public string Name {
		get { 
			return name;
		}
	}
}
