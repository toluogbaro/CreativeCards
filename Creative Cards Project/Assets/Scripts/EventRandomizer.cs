using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventRandomizer : MonoBehaviour
{

    #region Variables
    public float PercentageChance;
    public GameObject TopDownCamera;
    public GameObject EncounterCamera;
    public GameObject StandardEnemy;
    Vector3 EnemySpawnLocation;
    float Countdown;
    bool CountdownOn;
    public float TimeInEncounter;
    public GameObject Enemy;
    public Canvas EncounterCan;

    public GameObject GameManagerOBJ;
    public Canvas TopDownCan;
    public GameObject HealthSliderOBJ;
    #endregion


    // Start is called before the first frame update
    public void Start()
    {
        CountdownOn = false;
        Countdown = TimeInEncounter;
        EncounterCan.enabled = false;
        EnemySpawnLocation = new Vector3(-43.36f, -14.775f, 1.87f);
    }

    // Update is called once per frame
    public void Update()
    {
        if (Countdown <= 0) 
        {
            //Does the opposite to the RandomEvent function.
            
            Debug.Log("Encounter End");
            GetComponent<ClickRegister>().enabled = GetComponent<ClickRegister>();
            GetComponent<CameraMovement>().enabled = GetComponent<CameraMovement>();
            TopDownCamera.SetActive(true);
            EncounterCamera.SetActive(false);
            EncounterCan.enabled = false;
            TopDownCan.enabled = true;
            CountdownOn = false;
            Countdown = TimeInEncounter;
            GameManagerOBJ.GetComponent<GameManager>().CountdownEnabled = true;
        }

        if (CountdownOn == true) 
        {
            Countdown = Countdown - Time.deltaTime;  //Simple countdown clock to measure time in the encounter state. Can be Changed in inspector via the TimeInEncounter variable.
        }

    }

    public void RandomEvent() 
    {
        
        //Random.value returns a float between 0 - 1. If that float is less than the given percentage chance (That can be changed in the inspector) then it will turn off the controls for the top down movement and raycasting and switch cameras. 
        
        if (Random.value <= PercentageChance)
        {
            Enemy = Instantiate(StandardEnemy, EnemySpawnLocation, Quaternion.identity);
            HealthSliderOBJ.GetComponent<EnemyHealthSlider>().NewEnemy = true;
            GameManagerOBJ.GetComponent<GameManager>().CountdownEnabled = false;
            GetComponent<ClickRegister>().enabled = !GetComponent<ClickRegister>();
            GetComponent<CameraMovement>().enabled = !GetComponent<CameraMovement>();
            TopDownCamera.SetActive(false);
            EncounterCamera.SetActive(true);
            EncounterCan.enabled = true;
            TopDownCan.enabled = false;
            CountdownOn = true;     
        }
    }

    public void EndEvent() 
    {
        GetComponent<ClickRegister>().enabled = GetComponent<ClickRegister>();
        GetComponent<CameraMovement>().enabled = GetComponent<CameraMovement>();
        TopDownCamera.SetActive(true);
        EncounterCamera.SetActive(false);
        EncounterCan.enabled = false;
        TopDownCan.enabled = true;
        CountdownOn = false;
        Countdown = TimeInEncounter;
        GameManagerOBJ.GetComponent<GameManager>().CountdownEnabled = true;
        Destroy(Enemy);
    }
}
