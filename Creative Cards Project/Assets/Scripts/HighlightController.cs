using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightController : MonoBehaviour
{

    public float DimmingCount;
    public float HighlightCountdown;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HighlightCountdown > 0) 
        {
            if (DimmingCount < 50)
            {
                DimmingCount = DimmingCount + Time.deltaTime * 40;
            }
        }

        if (HighlightCountdown < 0) 
        {
            if (DimmingCount > 0) 
            {
                DimmingCount = DimmingCount - Time.deltaTime * 40;
            }
        }

        this.GetComponent<Light>().intensity = DimmingCount;

        HighlightCountdown = HighlightCountdown - Time.deltaTime;
    }
}
