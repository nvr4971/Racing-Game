using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObjects : MonoBehaviour
{
    public int GreenSelect;
    public GameObject FakeGreen;

    void Start()
    {
        GreenSelect = PlayerPrefs.GetInt("GreenBought");
        if (GreenSelect == 100)
        {
            FakeGreen.SetActive(false);
        }
    }
}