using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DaytimeSlider : MonoBehaviour
{
    public GameObject GameManagerOBJ;
    public Slider DaytimeSliderOBJ;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        DaytimeSliderOBJ.maxValue = GameManagerOBJ.GetComponent<GameManager>().DaytimeLength;
        DaytimeSliderOBJ.value = GameManagerOBJ.GetComponent<GameManager>().DaytimeTimer;
    }
}
