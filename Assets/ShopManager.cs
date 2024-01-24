using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public static ShopManager instance;

    public int coins = 100;

    public TextMeshProUGUI coinText;
    public GameObject shopUI;
    public Items[] items;
    public TMP_InputField coinsInputField;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void ToggleShop()
    {
        shopUI.SetActive(!shopUI.activeSelf);
    }
   /* private void OnGUI()
    {
        coinText.text = "Coins: " + coins.ToString();
    }*/
    public void UpdateCoins(string newcoins)
    {
        coinText.text = "Coins: "+newcoins;

    }
}
[System.Serializable]
public class Items
{
    public string name;
    public int cost;
    public Sprite image;
    [HideInInspector] public int quantity;
    [HideInInspector] public GameObject itemRef;
}
