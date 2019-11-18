using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemonText : MonoBehaviour
{
    public GameObject GameManagerOBJ;
    public Text DemonNumberText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DemonNumberText.text = "Demons:" + GameManagerOBJ.GetComponent<GameManager>().Demons;
    }
}
