using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    Dbmanager dataManager = Dbmanager.Instance;
    public Text ItemIdDisplay;
    public Text ItemNameDisplay;
    public Text ItemPriceDisplay;
    public static int ItemId;
    public static string ItemName;
    public static int ItemPrice;
    public static int RandomShopItem;
    string[] ItemArray = {"Full Heal", "New Gun", "New Wepon", "Nothing" ,"ReRoll"};
    int[] ItemPriceArray = {2,5,10,0,8};
    public Button RerollButton;
    // Start is called before the first frame update
        void Start()
    {
    //Random Shop Items Showing
       ItemId = Random.Range(1,5);
      
    }
    void Update(){
        ItemIdDisplay.text = ItemId.ToString();
        ItemNameDisplay.text = ItemName;
        ItemPriceDisplay.text = ItemPrice.ToString();
        ItemName = ItemArray[ItemId];
        ItemPrice = ItemPriceArray[ItemId];
        RerollButton.onClick.AddListener(OnClickTask);
    }
    void OnClickTask(){
        ItemId = Random.Range(1,5);
    }
}
