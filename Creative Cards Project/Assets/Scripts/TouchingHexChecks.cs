using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchingHexChecks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col) 
    {        
        if (col.gameObject.tag == "Hex") 
        {
            col.gameObject.GetComponent<HexIsTouched>().IsHexTouched = true;
            Debug.Log(col.gameObject.name);
        }
    }
}
