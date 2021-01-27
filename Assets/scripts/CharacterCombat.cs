using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCombat : MonoBehaviour
{
    public CharacterStatus myStats;
    // Start is called before the first frame update
    void Start()
    {
        myStats = GetComponent<CharacterStatus>();
    }

    public void MealeAttack (CharacterStatus targetStats)
    {
        targetStats.TakeDamage(myStats.damage);
    }

}
