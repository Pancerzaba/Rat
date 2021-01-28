using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCombat : MonoBehaviour
{
    public CharacterStatus myStats;
  
    void Start()
    {
        myStats = GetComponent<CharacterStatus>();
    }

    public void MealeAttack (CharacterStatus targetStats)
    {
        targetStats.TakeDamage(myStats.damage);
    }

}
