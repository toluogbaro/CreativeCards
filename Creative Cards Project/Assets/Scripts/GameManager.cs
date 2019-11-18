using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float DaytimeTimer;
    public float DaytimeLength;
    public bool CountdownEnabled;

    public int Demons;
    public int TilesTurned;
    public int StartingDemons;

    public int DaysPassed;
    // Start is called before the first frame update
    void Start()
    {
        DaytimeTimer = DaytimeLength;
        CountdownEnabled = true;
        Demons = StartingDemons;
    }

    // Update is called once per frame
    void Update()
    {
        if (CountdownEnabled == true) 
        {
            DaytimeCountdown();
        }


        if (DaytimeTimer <= 0) 
        {
            DayEnd();
        }
    }

    void DaytimeCountdown() 
    {
        DaytimeTimer = DaytimeTimer -= Time.deltaTime;
    }


    public void DayEnd() 
    {
        Demons += TilesTurned * 20;
        DaytimeTimer = DaytimeLength;
        DaysPassed += 1;
    } 
}
