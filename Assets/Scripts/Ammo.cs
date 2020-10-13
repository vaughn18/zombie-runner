using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] AmmoSlot[] ammoSlots;
    [System.Serializable]
    private class AmmoSlot
    {
        public AmmoType ammoType;
        public int ammoAmount;
    
    }

    public int ammoRemaining(AmmoType ammoType)
    {
        return getAmmoSlot(ammoType).ammoAmount;
    }


    public int shootAmmo(AmmoType ammoType)
    {   
        return getAmmoSlot(ammoType).ammoAmount--;
    }

    public int increaseAmmo(AmmoType ammoType, int ammoAmount)
    {
        return getAmmoSlot(ammoType).ammoAmount += ammoAmount;
    }

    private AmmoSlot getAmmoSlot(AmmoType ammoType)
    {
        foreach (AmmoSlot slot in ammoSlots )
        {
            if(slot.ammoType == ammoType)
            {
                return slot;
            }
        }
        return null;
    }
}
