using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaysText : MonoBehaviour
{
    public GameObject GameManagerOBJ;
    public Text DayNumberText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DayNumberText.text = "Days Passed:" + GameManagerOBJ.GetComponent<GameManager>().DaysPassed;
    }
}
