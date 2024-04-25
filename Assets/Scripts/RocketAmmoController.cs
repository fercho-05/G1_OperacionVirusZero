using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketAmmoController : MonoBehaviour
{
    [SerializeField]
    bool AmmoSelected;

    Ammo rocketAmmo;

    private void Awake()
    {
        rocketAmmo = FindObjectOfType<Ammo>();       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rocketAmmo.rockets += 1;
            if (AmmoSelected)
            {
                Destroy(gameObject);
            }
        }
    }
}