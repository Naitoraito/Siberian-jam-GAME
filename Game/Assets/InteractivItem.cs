using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractivItem : MonoBehaviour
{
    public SpriteRenderer Item;
    public Sprite preAnimationSprite;
    public Sprite animationSprite;
    public Sprite afterAnimation;
    public int carma;

    public void Interaction()
    {
        StartCoroutine(Animation());
    }

    IEnumerator Animation()
    {
        Item.sprite = animationSprite;
        yield return new WaitForSeconds(1f);
        Item.sprite = afterAnimation;
    }
}
