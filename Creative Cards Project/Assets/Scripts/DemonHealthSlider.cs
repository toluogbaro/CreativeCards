using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DemonHealthSlider : MonoBehaviour
{
    public Slider DemonHealthSlide;
    public GameObject GameManagerOBJ;
    public GameObject CamRigOBJ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CamRigOBJ.GetComponent<EventRandomizer>().NewFight == true)
        {
            DemonHealthSlide.maxValue = GameManagerOBJ.GetComponent<GameManager>().Demons;
            CamRigOBJ.GetComponent<EventRandomizer>().NewFight = false;
        }

        DemonHealthSlide.value = GameManagerOBJ.GetComponent<GameManager>().Demons;
    }
}
