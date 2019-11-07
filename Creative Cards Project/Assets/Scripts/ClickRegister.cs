using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRegister : MonoBehaviour
{


    public GameObject Light;
    public Vector3 LightHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        RayCastShoot();
    }

    public void RayCastShoot() 
    {
        RaycastHit hit;


        if (Input.GetMouseButtonDown(0)) 
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 20))
            {
                if (hit.collider.gameObject.tag == "Hex")
                {
                    Debug.Log("Hit" + hit.collider.gameObject);
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.black;
                    GetComponent<EventRandomizer>().RandomEvent();
                }
            }
        }

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 20))
        {
            if (hit.collider.gameObject.tag == "Hex")
            {
                GameObject HitObject = hit.collider.gameObject;
                Debug.Log("Hit" + hit.collider.gameObject);
                HitObject.GetComponentInChildren<HighlightController>().HighlightCountdown = 0.5f;
            }
        }
    }
}
