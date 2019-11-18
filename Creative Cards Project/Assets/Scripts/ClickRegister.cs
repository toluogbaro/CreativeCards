using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickRegister : MonoBehaviour
{


    public GameObject Light;
    public Vector3 LightHeight;
    public Material Tainted;
    public GameObject GameManagerOBJ;
    public int DemonsUsedToTakeTile;
    public bool FirstHit;
    // Start is called before the first frame update
    void Start()
    {
        FirstHit = true;
    }

    // Update is called once per frame
    public void Update()
    {
        RayCastShoot();
    }

    public void RayCastShoot() 
    {
        RaycastHit hit;

        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 20))
                {
                    if (hit.collider.gameObject.tag == "Hex")
                    {
                        if (FirstHit == true)
                        {  
                            hit.collider.gameObject.GetComponent<HexIsTouched>().IsTainted = true;
                            hit.collider.gameObject.GetComponent<Renderer>().material = Tainted;
                            GameManagerOBJ.GetComponent<GameManager>().TilesTurned += 1;
                            GameManagerOBJ.GetComponent<GameManager>().Demons -= DemonsUsedToTakeTile;
                            FirstHit = false;
                        }
                        
                        else if (hit.collider.gameObject.GetComponent<HexIsTouched>().IsHexTouched == true)
                        {
                            hit.collider.gameObject.GetComponent<HexIsTouched>().IsTainted = true;
                            hit.collider.gameObject.GetComponent<Renderer>().material = Tainted;
                            GameManagerOBJ.GetComponent<GameManager>().TilesTurned += 1;
                            GameManagerOBJ.GetComponent<GameManager>().Demons -= DemonsUsedToTakeTile;
                            GetComponent<EventRandomizer>().RandomEvent();
                        }
                    }
                }
            }
        }

        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 20))
            {
                if (hit.collider.gameObject.tag == "Hex")
                {
                    if (FirstHit == true)
                    {
                        GameObject HitObject = hit.collider.gameObject;
                        HitObject.GetComponentInChildren<HighlightController>().HighlightCountdown = 0.5f;
                    }

                    else if (hit.collider.gameObject.GetComponent<HexIsTouched>().IsHexTouched == true) 
                    {
                        GameObject HitObject = hit.collider.gameObject;
                        HitObject.GetComponentInChildren<HighlightController>().HighlightCountdown = 0.5f;
                    }        
                }
            }
        }
    }
}
