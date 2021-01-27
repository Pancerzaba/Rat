using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour

{
    float radius = 2f;

    GameObject player;

    public CharacterStatus myStats;
    // Start is called before the first frame update
    void Start()
    {
        //player.PlayerManager.instance.player;
        myStats = GetComponent<CharacterStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);

            if (distance <= radius)
            {
                CharacterCombat playerCambat = player.GetComponent<CharacterCombat>();
                if (playerCambat != null)
                    playerCambat.MealeAttack(myStats);
            }
        }   
    }

}

