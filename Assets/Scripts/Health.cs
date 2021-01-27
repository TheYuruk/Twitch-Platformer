using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Health : MonoBehaviour
{
    public enum AttacableObjectType
    {
        Player,
        Tree
    }
    public int health;
    public SpriteRenderer spriteRenderer;
    public AttacableObjectType objectType;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (objectType == AttacableObjectType.Tree)
        {
            HitFeedBack();
        }



        ChekIfWeDead();
    }
    
    private void ChekIfWeDead()
    {
        if (health <= 0)
        {
            health = 0;
            if (objectType == AttacableObjectType.Tree)
            {
                TreeDestroyFeedback();
            }

        }
    }
    private void HitFeedBack()
    {
        this.gameObject.transform.DOShakePosition(0.15f, new Vector3(0.4f, 0.1f, 0), 10, 90);
        Tween colorTween = spriteRenderer.DOBlendableColor(Color.red, 0.2f);
        colorTween.OnComplete(() => spriteRenderer.DOBlendableColor(Color.white, 0.5f));
    }
    private void TreeDestroyFeedback()
    {
        this.gameObject.transform.DOShakePosition(0.15f, new Vector3(0.4f, 0.1f, 0), 10, 90);
        Tween colorTween = spriteRenderer.DOBlendableColor(Color.red, 0.2f);
        colorTween.OnComplete(() => Destroy(gameObject));
    }
}
