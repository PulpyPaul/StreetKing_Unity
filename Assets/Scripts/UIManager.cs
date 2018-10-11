using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public List<GameObject> buyableItems;
	public List<GameObject> purchasedItems;
	public List<GameObject> buyableCustItems;
	public List<GameObject> custItems;

	public GameObject buyableItem;
	public GameObject purchasedItem;

	public GameObject dividerPrefab;

	// Home Screen Items
	public GameObject sell_Screen_Btn;
	public GameObject buy_Screen_Btn;
	public GameObject cust_Screen_Btn;

	// Sell Screen Items
	public List<GameObject> sellItems;
	public GameObject sellItemPrefab;
	public GameObject sell_Menu;
	public GameObject exit_Sell_Btn;

	// Buy Screen Items
	public GameObject buy_Menu;
	public GameObject exit_Buy_Btn;

	// Customize Screen Items
	public GameObject cust_Menu;
	public GameObject exit_Cust_Btn;

	public GameObject buyMenuContent;
	public GameObject sellMenuContent;

	public static UIManager instance = null;

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		buyableItems = new List<GameObject> ();
		sellItems = new List<GameObject> ();
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

	public void CreateBuyableItems(){

		for (int i = 0; i < 5; i++) {
			GameObject testBuyable = Instantiate (buyableItem, buyMenuContent.transform) as GameObject;
			buyableItems.Add (testBuyable);
		}
	}

	public void CreatePurchaseItems(){

		for (int i = 0; i < 5; i++) {
			GameObject testPurchased = Instantiate (purchasedItem, buyMenuContent.transform) as GameObject;
			purchasedItems.Add (testPurchased);
		}
	}

	public void SetupBuyScreen() {
		ToggleHomeButtons ();
		buy_Menu.SetActive (true);
		CreateBuyableItems ();
		CreateDivider ();
		CreatePurchaseItems ();
	}

	public void ReturnFromBuy() {
		ToggleHomeButtons ();
		buy_Menu.SetActive (false);
	}

	void CreateDivider() {
		GameObject divider = Instantiate (dividerPrefab, buyMenuContent.transform) as GameObject;
	}

	// ---------------------------------- SELL SCREEN FUNCTIONS ------------------------------------

	public void SetupSellScreen(){
		ToggleHomeButtons ();
		sell_Menu.SetActive (true);

		for (int i = 0; i < InventoryManager.instance.inventory.Count; i++) {
			GameObject sell_Prefab = Instantiate (sellItemPrefab, sellMenuContent.transform) as GameObject;
			Button[] sell_Btns = sell_Prefab.GetComponentsInChildren<Button> ();

			for (int j = 0; j < sell_Btns.Length; j++){
				sell_Btns [j].GetComponentInChildren<Text> ().text = Random.Range (InventoryManager.instance.inventory [i].SellLow, InventoryManager.instance.inventory [i].SellHigh + 1).ToString();
			}

			sellItems.Add (sell_Prefab);
		}
	}

	public void ReturnFromSell() {
		ToggleHomeButtons ();
		sell_Menu.SetActive (false);
	}

	public void RefreshValues() {
		for (int i = 0; i < sellItems.Count; i++) {
			Button[] sell_Btns = sellItems[i].GetComponentsInChildren<Button> ();

			for (int j = 0; j < sell_Btns.Length; j++){
				sell_Btns [j].GetComponentInChildren<Text> ().text = Random.Range (InventoryManager.instance.inventory [i].SellLow, InventoryManager.instance.inventory [i].SellHigh + 1).ToString();
			}
		}
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