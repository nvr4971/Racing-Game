using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlActive : MonoBehaviour
{
    public GameObject PlayerCar;
    public GameObject OpponentCar;

    void Start()
    {
        (PlayerCar.GetComponent("CarController") as MonoBehaviour).enabled = true;
        (OpponentCar.GetComponent("CarAIControl") as MonoBehaviour).enabled = true;
    }
}
