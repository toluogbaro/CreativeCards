using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventRandomizer : MonoBehaviour
{

    #region Variables
    public float PercentageChance;
    public GameObject TopDownCamera;
    public GameObject EncounterCamera;


    float Countdown;
    bool CountdownOn;
    public float TimeInEncounter;

    public Canvas EncounterCan;

    #endregion
    
    
    // Start is called before the first frame update
    public void Start()
    {
        CountdownOn = false;
        Countdown = TimeInEncounter;
        EncounterCan.enabled = false;
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
            CountdownOn = false;
            Countdown = TimeInEncounter;
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
            Debug.Log("Encounter");
            GetComponent<ClickRegister>().enabled = !GetComponent<ClickRegister>();
            GetComponent<CameraMovement>().enabled = !GetComponent<CameraMovement>();
            TopDownCamera.SetActive(false);
            EncounterCamera.SetActive(true);
            EncounterCan.enabled = true;
            CountdownOn = true;
        }
    }
}
