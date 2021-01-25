using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;

    public void TakeDamage(int damage)
    {
        health -= damage;
        ChekIfWeDead();
    }
    
    private void ChekIfWeDead()
    {
        if (health <= 0)
        {
            health = 0;
            Debug.Log("YOU ARE DIE " + gameObject.name);
            Destroy(gameObject);
        }
    }
}
