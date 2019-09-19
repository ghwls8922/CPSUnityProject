using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

    //소지금UI
    public Text textMoney;
    //소지금
    public static long money;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ShowMoneyText();
	}

    void ShowMoneyText()
    {
        textMoney.text = money.ToString("###,###");
    }
}
