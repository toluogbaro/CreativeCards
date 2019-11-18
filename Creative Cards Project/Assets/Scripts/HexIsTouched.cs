using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexIsTouched : MonoBehaviour
{
    public bool IsHexTouched;
    public bool IsTainted;
    public GameObject TouchingHexCheckOBJ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTainted) 
        {
            TouchingHexCheckOBJ.SetActive(true);
        }
    }
}
