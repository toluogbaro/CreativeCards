using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{


    public int EnemyHealth1, EnemyHealth2, EnemyHealth3;
    public float EnemyDifficulty;
    public GameObject FightManager;

    // Start is called before the first frame update
    void Start()
    {
        EnemyDifficulty = Random.value;

        if (EnemyDifficulty <= 0.5f) 
        {
           FightManager.GetComponent<FightManager>().EnemyHealth = EnemyHealth1;
        }

        if (EnemyDifficulty > 0.5f && EnemyDifficulty <= 0.8f) 
        {
            FightManager.GetComponent<FightManager>().EnemyHealth = EnemyHealth2;
        }

        if (EnemyDifficulty > 0.8f) 
        {
            FightManager.GetComponent<FightManager>().EnemyHealth = EnemyHealth3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
