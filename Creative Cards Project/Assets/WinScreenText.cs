using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinScreenText : MonoBehaviour
{
    public GameObject GameManagerOBJ;
    public Text WinDaysText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WinDaysText.text = "You Won in " + GameManagerOBJ.GetComponent<GameManager>().DaysPassed + " Days";
    }
}
