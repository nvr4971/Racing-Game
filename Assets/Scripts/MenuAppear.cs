using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour
{
    public GameObject LargeButton;
    public GameObject TextClick;
    public GameObject MenuButtons;

    public void StartMenu()
    {
        TextClick.SetActive(false);
        MenuButtons.SetActive(true);
        LargeButton.SetActive(false);
    }
}
