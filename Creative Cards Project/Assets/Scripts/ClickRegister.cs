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
    public GameObject EncounterPanelOBJ;
    // Start is called before the first frame update
    void Start()
    {
        FirstHit = true;
    }

    // Update is called once per frame
    public void Update()
    {
        RayCastShoot();


        DemonsUsedToTakeTile = 10 + (GameManagerOBJ.GetComponent<GameManager>().TilesTurned * 2);
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
                        if (hit.collider.gameObject.GetComponent<HexIsTouched>().IsHexTouched == true)
                        {
                            hit.collider.gameObject.GetComponent<HexIsTouched>().IsTainted = true;
                            hit.collider.gameObject.GetComponent<Renderer>().material = Tainted;
                            GameManagerOBJ.GetComponent<GameManager>().TilesTurned += 1;
                            GameManagerOBJ.GetComponent<GameManager>().Demons -= DemonsUsedToTakeTile;
                            GetComponent<EventRandomizer>().RandomEvent();
                        }
                    }
                    #region SinHexs
                    if (hit.collider.gameObject.tag == "Glutony") 
                    {
                        hit.collider.gameObject.GetComponent<GlutonyMoveAdd>().AddGlutonyAttack();
                        hit.collider.gameObject.GetComponent<HexIsTouched>().IsTainted = true;
                        hit.collider.gameObject.GetComponent<Renderer>().material = Tainted;
                    }
                    if (hit.collider.gameObject.tag == "Lust")
                    {
                        hit.collider.gameObject.GetComponent<LustMoveAdd>().AddLustAttack();
                        hit.collider.gameObject.GetComponent<HexIsTouched>().IsTainted = true;
                        hit.collider.gameObject.GetComponent<Renderer>().material = Tainted;
                    }
                    if (hit.collider.gameObject.tag == "Sloth")
                    {
                        hit.collider.gameObject.GetComponent<SlothMoveAdd>().AddSlothAttack();
                        hit.collider.gameObject.GetComponent<HexIsTouched>().IsTainted = true;
                        hit.collider.gameObject.GetComponent<Renderer>().material = Tainted;
                    }
                    if (hit.collider.gameObject.tag == "Pride")
                    {
                        hit.collider.gameObject.GetComponent<PrideMoveAdd>().AddPrideAttack();
                        hit.collider.gameObject.GetComponent<HexIsTouched>().IsTainted = true;
                        hit.collider.gameObject.GetComponent<Renderer>().material = Tainted;
                    }
                    if (hit.collider.gameObject.tag == "Envy")
                    {
                        hit.collider.gameObject.GetComponent<EnvyMoveAdd>().AddEnvyAttack();
                        hit.collider.gameObject.GetComponent<HexIsTouched>().IsTainted = true;
                        hit.collider.gameObject.GetComponent<Renderer>().material = Tainted;
                    }
                    if (hit.collider.gameObject.tag == "Anger")
                    {
                        hit.collider.gameObject.GetComponent<AngerMoveAdd>().AddAngerAttack();
                        hit.collider.gameObject.GetComponent<HexIsTouched>().IsTainted = true;
                        hit.collider.gameObject.GetComponent<Renderer>().material = Tainted;
                    }
                    if (hit.collider.gameObject.tag == "Greed")
                    {
                        hit.collider.gameObject.GetComponent<GreedMoveAdd>().AddGreedAttack();
                        hit.collider.gameObject.GetComponent<HexIsTouched>().IsTainted = true;
                        hit.collider.gameObject.GetComponent<Renderer>().material = Tainted;
                    }
                    #endregion
                }
            }
        }

        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 20))
            {
                if (hit.collider.gameObject.tag == "Hex" || hit.collider.gameObject.tag == "Glutony" || hit.collider.gameObject.tag == "Lust" || hit.collider.gameObject.tag == "Sloth" || hit.collider.gameObject.tag == "Pride" || hit.collider.gameObject.tag == "Envy" || hit.collider.gameObject.tag == "Anger" || hit.collider.gameObject.tag == "Greed")
                {
                    if (hit.collider.gameObject.tag == "Glutony" || hit.collider.gameObject.tag == "Lust" || hit.collider.gameObject.tag == "Sloth" || hit.collider.gameObject.tag == "Pride" || hit.collider.gameObject.tag == "Envy" || hit.collider.gameObject.tag == "Anger" || hit.collider.gameObject.tag == "Greed") 
                    {
                        GameObject HitObject = hit.collider.gameObject;
                        HitObject.GetComponentInChildren<HighlightController>().HighlightCountdown = 0.5f;
                    }
                    if (hit.collider.gameObject.GetComponent<HexIsTouched>().IsHexTouched == true) 
                    {
                        GameObject HitObject = hit.collider.gameObject;
                        HitObject.GetComponentInChildren<HighlightController>().HighlightCountdown = 0.5f;
                    }        
                }
            }
        }
    }
}
