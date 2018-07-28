using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject SwordObject, GunObject;

    private void Start()
    {
        SetSword();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            SetSword();
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            SetGun();
    }

    void SetSword()
    {
        SwordObject.SetActive(true);
        GunObject.SetActive(false);
    }

    void SetGun()
    {
        SwordObject.SetActive(false);
        GunObject.SetActive(true);
    }
}
