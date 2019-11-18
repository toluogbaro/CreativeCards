using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{

    public bool IsPlayersTurn;

    public GameObject GameManagerOBJ;

    public float Move;

    public int Move1Damage, Move2Damage, Move3Damage;

    public int EnemyHealth;

    public GameObject CamRig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayersTurn == false) 
        {
            EnemyTurn();
        }

        // If Enemy Health is 0 or less, return to top down view
        if (EnemyHealth <= 0) 
        {
            CamRig.GetComponent<EventRandomizer>().EndEvent();
        }
    }


    void EnemyTurn() 
    {
        Move = Random.value;
        
        if (Move <= 0.6f) 
        {
            GameManagerOBJ.GetComponent<GameManager>().Demons -= Move1Damage;
            IsPlayersTurn = true;
        }

        if (Move > 0.6f && Move <= 0.9f)
        {
            GameManagerOBJ.GetComponent<GameManager>().Demons -= Move2Damage;
            IsPlayersTurn = true;
        }

        if (Move > 0.9f)
        {
            GameManagerOBJ.GetComponent<GameManager>().Demons -= Move3Damage;
            IsPlayersTurn = true;
        }
    }
}
