using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour
{
    public GameObject GreenButton;
    public int CashValue;

    void Update()
    {
        CashValue = GlobalCash.TotalCash;
        if (CashValue >= 100)
        {
            GreenButton.GetComponent<Button>().interactable = true;
        }
    }

    public void GreenUnlock()
    {
        GreenButton.SetActive(false);
        CashValue -= 100;
        GlobalCash.TotalCash -= 100;
        PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        PlayerPrefs.SetInt("GreenBought", 100);
    }
}
