using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public float DaytimeTimer;
    public float DaytimeLength;
    public bool CountdownEnabled;

    public int Demons;
    public int TilesTurned;
    public int StartingDemons;

    public int DaysPassed;

    public Canvas GameOverCan;
    public Canvas WinCan;
    // Start is called before the first frame update
    void Start()
    {
        DaytimeTimer = DaytimeLength;
        CountdownEnabled = true;
        Demons = StartingDemons;
        GameOverCan.enabled = false;
        WinCan.enabled = false;
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

        if (Demons <= 0) 
        {
            GameOverCan.enabled = true;
        }

        if (TilesTurned == 72) 
        {
            WinCan.enabled = true;
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
