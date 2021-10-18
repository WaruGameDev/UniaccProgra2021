using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : MonoBehaviour
{
    public static HeroManager instance;
    public Transform heroSpawner, enemySpawner;
    public GameObject heroObject;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    public void AddHero(int i)
    {        
        GameObject heroGo = Instantiate(heroObject, heroSpawner.position, Quaternion.identity);
        Hero newHero = heroGo.GetComponent<Hero>();
        switch(i)
        {
            case 0:
                newHero.weapon = WEAPON_TYPE.ESPADA;
                break;
            case 1:
                newHero.weapon = WEAPON_TYPE.LANZA;
                break;
            case 2:
                newHero.weapon = WEAPON_TYPE.HACHA;
                break;

        }        
        newHero.playerUnit = true;
        newHero.direction = new Vector2(1, 0);
    }
    public void AddEnemy()
    {
        GameObject heroGo = Instantiate(heroObject, enemySpawner.position, Quaternion.identity);
        Hero newHero = heroGo.GetComponent<Hero>();
        newHero.weapon = (WEAPON_TYPE)Random.Range(0, 2);
        newHero.playerUnit = false;
        newHero.direction = new Vector2(-1, 0);
    }
    IEnumerator CreateEnemy()
    {
        while(true)
        {
            AddEnemy();
            yield return new WaitForSeconds(2);
        }
        yield break;
    }

     
}
