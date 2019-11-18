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
        Debug.Log("Collider Activeted and Hit other hex");
        
        if (col.gameObject.tag == "Hex") 
        {
            col.gameObject.GetComponent<HexIsTouched>().IsHexTouched = true;
            Debug.Log(col.gameObject.name);
        }
    }
}
