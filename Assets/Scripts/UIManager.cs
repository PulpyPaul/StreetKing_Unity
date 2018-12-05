using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public List<GameObject> buyableItems;
	public List<GameObject> purchasedItems;
	public List<GameObject> buyableCustItems;
	public List<GameObject> custItems;

	// Home Screen Items
	public GameObject sell_Screen_Btn;
	public GameObject buy_Screen_Btn;
	public GameObject cust_Screen_Btn;

	// Sell Screen Items
	public List<GameObject> sellItems;
	public GameObject sellItemPrefab;
	public GameObject sell_Menu;
	public GameObject exit_Sell_Btn;
	public GameObject currMoney;
	public GameObject sellDynamics;

	bool sellItemsCreated;

	// Buy Screen Items
	public GameObject buy_Menu;
	public GameObject exit_Buy_Btn;
    public GameObject buyableItem;
    public GameObject purchasedItem;
    public GameObject dividerPrefab;
	public CurrentCashValues buyMenuCash;

    bool buyItemsCreated;

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
		//buyableItems = new List<GameObject> ();
		sellItems = new List<GameObject> ();
		sellItemsCreated = false;
		buyItemsCreated = false;
	}

	// ------------------------------ HOME SCREEN FUNCTIONS -------------------------

	public void ToggleHomeButtons() {
		sell_Screen_Btn.SetActive (!sell_Screen_Btn.activeSelf);
		buy_Screen_Btn.SetActive (!buy_Screen_Btn.activeSelf);
		cust_Screen_Btn.SetActive (!cust_Screen_Btn.activeSelf);
	}

	// ----------------------------- BUY SCREEN Functions -------------------------
	public void AddPurchasedItem(Item item){
		GameObject purchItem = Instantiate(purchasedItem, buyMenuContent.transform) as GameObject;
		purchItem.GetComponent<PurchasedItem> ().StartTimer (item);
		purchasedItems.Add(purchItem);
		buyMenuCash.updateCash ();
    }

	public void CreateBuyableItems(){

        for (int i = 0; i < buyableItems.Count; i++) {
			GameObject buyable = Instantiate (buyableItems[i], buyMenuContent.transform) as GameObject;
         }

		buyItemsCreated = true;
	}

	public void CreatePurchaseItems(){

		/*for (int i = 0; i < 5; i++) {
			GameObject testPurchased = Instantiate (purchasedItem, buyMenuContent.transform) as GameObject;
			purchasedItems.Add (testPurchased);
		}*/
	}

	public void SetupBuyScreen() {
		ToggleHomeButtons ();
		buy_Menu.SetActive (true);

		if (!buyItemsCreated) {
			CreateBuyableItems ();
			CreateDivider ();
			CreatePurchaseItems ();
		}
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

		if (!sellItemsCreated) {
			CreateSellItems ();
		} else if (sellItems.Count != InventoryManager.instance.inventory.Count) {
			sellItems.Clear ();
			ClearSellMenu ();
			CreateSellItems ();
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

	public void RefreshMoney() {
		currMoney.GetComponent<Text> ().text = "Total Cash: $" +MoneyManager.instance.TotalMoney.ToString();
	}

	public void RemoveSoldItem() {
		
	}

	void CreateSellItems() {
		
		for (int i = 0; i < InventoryManager.instance.inventory.Count; i++) {
			GameObject sell_Prefab = Instantiate (sellItemPrefab, sellMenuContent.transform) as GameObject;
			Button[] sell_Btns = sell_Prefab.GetComponentsInChildren<Button> ();

			for (int j = 0; j < sell_Btns.Length; j++){
				sell_Btns [j].GetComponentInChildren<Text> ().text = Random.Range (InventoryManager.instance.inventory [i].SellLow, InventoryManager.instance.inventory [i].SellHigh + 1).ToString();
			}

			sell_Prefab.GetComponent<SellItem> ().ItemID = InventoryManager.instance.inventory [i].ID;

			sellItems.Add (sell_Prefab);
		}

		sellItemsCreated = true;
	}

	void ClearSellMenu() {
		for (int i = 0; i < sellDynamics.transform.childCount; i++) {
			GameObject.Destroy(sellDynamics.transform.GetChild(i).gameObject);
		}
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