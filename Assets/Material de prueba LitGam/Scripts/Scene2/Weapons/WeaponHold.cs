using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHold : MonoBehaviour
{
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;


    public void ActivateWeapon1()
    {
        weapon1.SetActive(true);
        weapon2.SetActive(false);
        weapon3.SetActive(false);
    }

    public void ActivateWeapon2()
    {
        weapon1.SetActive(false);
        weapon2.SetActive(true);
        weapon3.SetActive(false);
    }

    public void ActivateWeapon3()
    {
        weapon1.SetActive(false);
        weapon2.SetActive(false);
        weapon3.SetActive(true);
    }


}
