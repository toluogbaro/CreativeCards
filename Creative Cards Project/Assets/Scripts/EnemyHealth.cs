using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{



    public float EnemyDifficulty;
    public GameObject FightManager;
    public GameObject GameManager;
    // Start is called before the first frame update

    void Start()
    {
        FightManager = GameObject.FindGameObjectWithTag("FM");
        GameManager = GameObject.FindGameObjectWithTag("GM");
        
        EnemyDifficulty = Random.value;

        if (EnemyDifficulty <= 0.5f) 
        {
           FightManager.GetComponent<FightManager>().EnemyHealth = 20 * (Random.Range(10 , (GameManager.GetComponent<GameManager>().Demons / 2)));
        }

        if (EnemyDifficulty > 0.5f && EnemyDifficulty <= 0.8f) 
        {
            FightManager.GetComponent<FightManager>().EnemyHealth = 25 * (Random.Range(10, (GameManager.GetComponent<GameManager>().Demons / 2)));
        }

        if (EnemyDifficulty > 0.8f) 
        {
            FightManager.GetComponent<FightManager>().EnemyHealth = 30 * (Random.Range(10, (GameManager.GetComponent<GameManager>().Demons / 2)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
