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

	/// <summary>
	/// Adds funds to the total amount of cash for the player
	/// </summary>
	/// <param name="amount">Amount.</param>
	public void AddFunds(int amount) {
		totalMoney += amount;
		UIManager.instance.RefreshMoney ();
	}

	public void RemoveFunds(int amount) {
		totalMoney -= amount;
	}

	public bool CheckFunds(int amount) {
		if (amount <= totalMoney) {
			return true;
		} else {
			return false;
		}
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
