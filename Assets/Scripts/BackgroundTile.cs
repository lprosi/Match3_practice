using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class BackgroundTile : MonoBehaviour
{
    public int hitPoints;
    private SpriteRenderer sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(hitPoints <= 0)
        {
            Destroy(this.gameObject); 
        }
    }

    public void TakeDamage(int damage)
    {
        hitPoints -= damage;
        MakeLighter();
    }

    void MakeLighter()
    {
        //взять текущий цвет
        Color color = sprite.color;
        //получить значение текущего цвета и сократить его на 2
        float newAlpha = color.a * .5f;
        sprite.color = new Color(color.r, color.g, color.b, newAlpha);
    }

}
