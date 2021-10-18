using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public enum WEAPON_TYPE
{
    ESPADA, HACHA, LANZA
}

public class Hero : MonoBehaviour
{
    
    public WEAPON_TYPE weapon;

    public Sprite[] sprites;

    public int atk, def;
    public bool playerUnit;
    public bool atacking;
    public float speed = 2;
    public Vector2 direction = new Vector2(-1, 0);

    private void Start()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        switch(weapon)
        {
            case WEAPON_TYPE.ESPADA:
                sp.sprite = sprites[0];
                break;
            case WEAPON_TYPE.LANZA:
                sp.sprite = sprites[1];
                break;
            case WEAPON_TYPE.HACHA:
                sp.sprite = sprites[2];
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Unit"))
        {
            Hero h = other.GetComponent<Hero>();
            
            if(h.playerUnit != playerUnit && h !=null)
            {
                atacking = true;
                StartCoroutine(Attacking(h));
            }

           
        }
    }
    IEnumerator Attacking(Hero h)
    {
        bool isWeak = false;
        if(weapon == WEAPON_TYPE.ESPADA && h.weapon == WEAPON_TYPE.HACHA)
        {
            isWeak = true;
        }
        if(weapon == WEAPON_TYPE.HACHA && h.weapon == WEAPON_TYPE.LANZA)
        {
            isWeak = true;
        }
        if (weapon == WEAPON_TYPE.LANZA && h.weapon == WEAPON_TYPE.ESPADA)
        {
            isWeak = true;
        }

        while (h.def >= 0)
        {           
            if(isWeak)
            {
                h.def -= (atk*2);
            }
            else
            {
                h.def -= atk;
            }
            
            if(h.def <= 0)
            {
                h.gameObject.SetActive(false);
            }
            yield return new WaitForSeconds(1);
        }
        atacking = false;
        yield break;
    }
    private void Update()
    {
        if(!atacking)
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }
        
    }


}
