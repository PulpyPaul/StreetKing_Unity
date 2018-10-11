using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour {

	int totalMoney;

	public static MoneyManager instance = null;

	void Awake() {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		totalMoney = 100;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddFunds() {
		
	}

	public void RemoveFunds() {
	
	}

	public void CheckFunds() {
		
	}

	public int TotalMoney {
		get {
			return totalMoney;
		}
		set { 
			totalMoney = value;
		}
	}
}
