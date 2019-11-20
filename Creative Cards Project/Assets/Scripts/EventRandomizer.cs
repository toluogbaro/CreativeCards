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
    public GameObject Chastity;
    public GameObject Temperance;
    public GameObject Charity;
    public GameObject Diligence;
    public GameObject Forgiveness;
    public GameObject Kindness;
    public GameObject Humility;

    public Canvas EncounterCan;

    public GameObject GameManagerOBJ;
    public Canvas TopDownCan;
    public GameObject HealthSliderOBJ;
    public bool NewFight;
    public GameObject EncounterPanel;
    #endregion


    // Start is called before the first frame update
    public void Start()
    {
        NewFight = false;
        CountdownOn = false;
        Countdown = TimeInEncounter;
        EncounterCan.enabled = false;
        EnemySpawnLocation = new Vector3(-43.36f, -16.1f, 1.87f);
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
            EncounterPanel.GetComponent<MoveAssignment>().LustCounter = 0;
            NewFight = true;
            Enemy = Instantiate(StandardEnemy, EnemySpawnLocation, Quaternion.Euler(0, 90, 0));
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

    public void LustFight() 
    {
        EncounterPanel.GetComponent<MoveAssignment>().LustCounter = 0;
        NewFight = true;
        Enemy = Instantiate(Chastity, EnemySpawnLocation, Quaternion.Euler(0, 90, 0));
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

    public void Glutony() 
    {
        EncounterPanel.GetComponent<MoveAssignment>().LustCounter = 0;
        NewFight = true;
        Enemy = Instantiate(Temperance, EnemySpawnLocation, Quaternion.Euler(0, 90, 0));
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

    public void Greed() 
    {
        EncounterPanel.GetComponent<MoveAssignment>().LustCounter = 0;
        NewFight = true;
        Enemy = Instantiate(Charity, EnemySpawnLocation, Quaternion.Euler(0, 90, 0));
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

    public void Sloth() 
    {
        EncounterPanel.GetComponent<MoveAssignment>().LustCounter = 0;
        NewFight = true;
        Enemy = Instantiate(Diligence, EnemySpawnLocation, Quaternion.Euler(0, 90, 0));
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

    public void Anger() 
    {
        EncounterPanel.GetComponent<MoveAssignment>().LustCounter = 0;
        NewFight = true;
        Enemy = Instantiate(Forgiveness, EnemySpawnLocation, Quaternion.Euler(0, 90, 0));
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

    public void Envy() 
    {
        EncounterPanel.GetComponent<MoveAssignment>().LustCounter = 0;
        NewFight = true;
        Enemy = Instantiate(Kindness, EnemySpawnLocation, Quaternion.Euler(0, 90, 0));
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

    public void Pride() 
    {
        EncounterPanel.GetComponent<MoveAssignment>().LustCounter = 0;
        NewFight = true;
        Enemy = Instantiate(Humility, EnemySpawnLocation, Quaternion.Euler(0, 90, 0));
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
