using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBase : MonoBehaviour
{
    public UnitStats Stats { get; private set; }
    public virtual void SetStats(UnitStats stats) => Stats = stats;

    public virtual void TakeDamage(int dmg) {
        //Override this to do some specific logic to each units.
    }
}
