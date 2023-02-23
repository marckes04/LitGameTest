using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;

void Start() {
    weapon1.SetActive(true);
    weapon2.SetActive(false);
    weapon3.SetActive(false);
}

void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            weapon1.SetActive(true);
            weapon2.SetActive(false);
            weapon3.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            weapon1.SetActive(false);
            weapon2.SetActive(true);
            weapon3.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            weapon1.SetActive(false);
            weapon2.SetActive(false);
            weapon3.SetActive(true);
        }
    }
}
