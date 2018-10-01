using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public List<GameObject> buyableItems;
	public List<GameObject> purchasedItems;
	public List<GameObject> sellItems;
	public List<GameObject> buyableCustItems;
	public List<GameObject> custItems;

	public GameObject buyableItem;
	public GameObject purchasedItem;


	// Home Screen Items
	public GameObject sell_Screen_Btn;
	public GameObject buy_Screen_Btn;
	public GameObject cust_Screen_Btn;

	// Sell Screen Items
	public GameObject sell_Menu;
	public GameObject exit_Sell_Btn;

	// Buy Screen Items
	public GameObject buy_Menu;
	public GameObject exit_Buy_Btn;

	// Customize Screen Items
	public GameObject cust_Menu;
	public GameObject exit_Cust_Btn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// ------------------------------ HOME SCREEN FUNCTIONS -------------------------

	public void ToggleHomeButtons() {
		sell_Screen_Btn.SetActive (!sell_Screen_Btn.activeSelf);
		buy_Screen_Btn.SetActive (!buy_Screen_Btn.activeSelf);
		cust_Screen_Btn.SetActive (!cust_Screen_Btn.activeSelf);
	}

	// ----------------------------- BUY SCREEN Functions -------------------------
	public void AddPurchasedItem(){

	}

	public void RemovePurchasedItem(){

	}

	public void PositionPurchasedItems(){

	}

	public void CreateBuyableItems(){

	}

	public void CreatePurchaseItems(){

	}

	public void SetupBuyScreen() {
		ToggleHomeButtons ();
		buy_Menu.SetActive (true);
	}

	public void ReturnFromBuy() {
		ToggleHomeButtons ();
		buy_Menu.SetActive (false);
	}

	// ---------------------------------- SELL SCREEN FUNCTIONS ------------------------------------

	public void SetupSellScreen(){
		ToggleHomeButtons ();
		sell_Menu.SetActive (true);
	}

	public void ReturnFromSell() {
		ToggleHomeButtons ();
		sell_Menu.SetActive (false);
	}

	public void PositionSellItems() {
		
	}

	public void StartRefresh() {
	
	}

	public void RefreshValues() {
	
	}

	public void RemoveSoldItem() {
	
	}

	// --------------------------------- CUSTOM SCREEN FUNCTIONS ----------------------------------
	public void SetupCustScreen(){
		ToggleHomeButtons ();
		cust_Menu.SetActive (true);
	}

	public void ReturnFromCust(){
		ToggleHomeButtons ();
		cust_Menu.SetActive (false);
	}

	public void CreateBuyableCustItems() {
		
	}

	public void CreateCustItems() {
		
	}

	public void PositionCustItems() {
	
	}

	public void AddCustItem() {
	
	}

	public void RemoveCustItem() {
		
	}
}