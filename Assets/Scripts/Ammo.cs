using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] int ammoAmount = 10;

    private int currentAmmoAmt;


    private void Start()
    {
        currentAmmoAmt = ammoAmount;
    }

    public int ammoRemaining()
    {
        return currentAmmoAmt;
    }
    

    public void shootAmmo()
    {
        currentAmmoAmt--;
    }
}
