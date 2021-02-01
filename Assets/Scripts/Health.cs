using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Health : MonoBehaviour
{
    
    public int health;
    
    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        
    }

    protected virtual void HitFeedBack()
    {
        //POP UP
        Debug.Log("Hit Feedback is playing");
       
    }

    protected virtual void OnDeath()
    {
        Debug.Log("You are die");
    }


    protected bool ChekIfWeDead()
    {
        if (health <= 0)
        {
            health = 0;  
            return true;
        }
        return false;
    }
}
