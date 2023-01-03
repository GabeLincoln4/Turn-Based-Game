using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private float damage;
    
    public float DisplayAttackData(string attackerName, string victimName, string attackType, float attackPower)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attackType = "Sword";
            Debug.Log(attackerName + " attacked " + victimName + " with a " + attackType + " attack!");
        }

        if (attackType == "Sword")
        {
            damage = 65f;
        }

        return damage;
    }
}
