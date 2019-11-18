using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthSlider : MonoBehaviour
{
    public Slider EnemyHealthSlide;
    public GameObject FightManager;
    public bool NewEnemy;
    // Start is called before the first frame update
    void Start()
    {
        NewEnemy = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (NewEnemy == true) 
        {
            EnemyHealthSlide.maxValue = FightManager.GetComponent<FightManager>().EnemyHealth;
            NewEnemy = false;
        }
        
        EnemyHealthSlide.value = FightManager.GetComponent<FightManager>().EnemyHealth;
    }
}
