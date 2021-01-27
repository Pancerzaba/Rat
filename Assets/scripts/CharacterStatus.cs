using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public int damage;
    bool isDead = false;

    public void TakeDamage(int damage)
    {
        health -= damage;
        CheckHealt();
    }
    public virtual void Die()
    {

    }

    void CheckHealt()
    {
        if (health<=0)
        {
            health = 0;
            isDead = true;
            Die();
        }
        if (health >= maxHealth)
            health = maxHealth;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}